using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;


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

        public void MapBlocks()
        {
            int rmblock;
            for (int i = 0; i < BlockOffset; i++)
            {
                rmblock = Word.HexToInt(RealMachine.Memory[RealMachine.PTR, i].Value);
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
