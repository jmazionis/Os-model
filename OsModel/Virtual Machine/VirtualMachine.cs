using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using OsModel;


namespace OsModel.VirtualMachineEmulator
{
    public class VirtualMachine
    {
        public event VMEventHandler VMTaskFinished;
        private VirtualCpu cpu;
        private IO io;
        private Memory memory;
        private TaskLoader task;
        public static int BlockOffset = 0;
        //private object[] registerState = new object[4];

        public VirtualMachine(string fileName)
        {
            memory = new Memory(Memory.VIRTUAL_MEMORY_BLOCK_COUNT, Memory.BLOCK_WORD_COUNT);
            this.task = new TaskLoader(fileName, memory);
            task.Load();
            cpu = new VirtualCpu(memory, this);
            io = new IO();
            BlockOffset += Memory.VIRTUAL_MEMORY_BLOCK_COUNT;
            this.MapBlocks();
            VMTaskFinished += ReduceOffset;
        }

        public void ExecuteAsProcess()
        {
            /*registerState[0] = OsModel.Cpu.PC;
            registerState[1] = OsModel.Cpu.AX.Clone();
            registerState[2] = OsModel.Cpu.CX.Clone();
            registerState[3] = OsModel.Cpu.SF;*/
            OsModel.Cpu.TIME = OsModel.Cpu.TIMER_TACTS;
            OsModel.Cpu.AX = this.cpu.AX;
            OsModel.Cpu.CX = this.cpu.CX;
            OsModel.Cpu.PC = this.cpu.PC;
            OsModel.Cpu.SF = this.cpu.SF;
            while (OsModel.Cpu.TIME > 0)
                this.ExecuteNext();
            this.cpu.AX = OsModel.Cpu.AX;
            this.cpu.CX = OsModel.Cpu.CX;
            this.cpu.PC = OsModel.Cpu.PC;
            this.cpu.SF = OsModel.Cpu.SF;
            OsModel.Cpu.TIME = 0;
            /*OsModel.Cpu.PC = (short)registerState[0];
            OsModel.Cpu.AX = (Word)(registerState[1] as Word).Clone();
            OsModel.Cpu.CX = (Word)(registerState[2] as Word).Clone();
            OsModel.Cpu.SF = (byte)registerState[3];*/

        }

        public void MapBlocks()
        {
            int rmblock;
            for (int i = 0; i < Memory.VIRTUAL_MEMORY_BLOCK_COUNT; i++)
            {
                rmblock = Word.HexToInt(RealMachine.Memory[OsModel.Cpu.PTR, i + BlockOffset - 5].Value);
                for (int j = 0; j < Memory.BLOCK_WORD_COUNT; j++)
                {
                    RealMachine.Memory[rmblock, j] = this.memory[i, j];
                }            
            }
        }

        private void ReduceOffset()
        {
            BlockOffset -= Memory.VIRTUAL_MEMORY_BLOCK_COUNT;
        }

        public void CheckIfInputNext()
        {
            if (cpu.NextCommand().Substring(0, 2) == "GD")
                io.ReadBuffer();
        }

        public void ExecuteNext()
        {
            if (!cpu.ExecuteNext() && VMTaskFinished != null)
                VMTaskFinished();
            CheckIfInputNext();
        }

        public void ExecuteAll()
        {
            while (true)
            {
                if (!cpu.ExecuteNext() && VMTaskFinished != null)
                {
                    VMTaskFinished();
                    return;
                }
                CheckIfInputNext();
            }
        }

        public Memory Memory
        {
            get { return memory; }
        }

        public IO Io
        {
            get { return io; }
        }

        public VirtualCpu Cpu
        {
            get { return cpu; }
        }
    }
}
