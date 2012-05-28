using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsModel.VirtualMachineEmulator
{
    public class VirtualCpu
    {
        public event VMEventHandler CommandExecuted;
        private Memory memory;
        public VirtualMachine vm;
        public short PC { get; set; }
        public Word AX { get; set; }
        public Word CX { get; set; }
        public byte SF { get; set; }

        public VirtualCpu(Memory memory, VirtualMachine vm)
        {
            
            this.vm = vm;
            this.memory = memory;
            this.PC = 0;
            this.AX = new Word(0);
            this.CX = new Word(0);
            this.SF = 0;
        }

        

        public bool ExecuteNext()
        {
            int block = Cpu.PC / 16;
            int word = Cpu.PC % 16;
            if (!(this.memory[block, word].Value == "$END"))
            {
                if (this.memory[block, word].Value == "----")
                {
                    FindNextCommand();
                    return true;
                }
                this.ExecuteCommand(this.memory[block, word]);
                if (!(this.memory[block, word].Value[0] == 'J'))
                    Cpu.PC++;
                if (CommandExecuted != null)
                {
                    CommandExecuted();
                }
                return true;
            }
            return false;
        }

        private void FindNextCommand()
        {
            while (true)
            {
                Cpu.PC++;
                if (this.memory[Cpu.PC / 16, Cpu.PC % 16].Value != "----")
                    return;
            }
        }


        public string NextCommand()
        {
            return this.memory[Cpu.PC / 16, Cpu.PC % 16].Value;
        }

        public void ExecuteCommand(Word word)
        {
            string command = word.Value.Substring(0, 2);
            string operand = "";
            if (word.Value.Length != 3)
            {
                operand = word.Value.Substring(2, word.Value.Length - 2);
            }
           
            switch (command)
            {
                case "AD":
                    {
                        Cpu.TIME--;
                        Cpu.AX = Cpu.AX + Cpu.CX;
                        break;
                    }
                case "SU":
                    {
                        Cpu.TIME--;
                        Cpu.AX = Cpu.AX - Cpu.CX;
                        break;
                    }
                case "CM":
                    {
                        Cpu.TIME--;
                        if (Cpu.AX > Cpu.CX)
                            Cpu.SF = 0;
                        if (Cpu.AX < Cpu.CX)
                            Cpu.SF = 2;
                        if (Word.HexToInt(Cpu.AX.Value) == Word.HexToInt(Cpu.CX.Value))
                            Cpu.SF = 1;
                        break;
                    }
                case "SA":
                    {
                        Cpu.TIME--;
                        this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value = Cpu.AX.Value;
                        break;
                    }
                case "LA":
                    {
                        Cpu.TIME--;
                        Cpu.AX.Value = this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value;
                        break;
                    }
                case "SC":
                    {
                        Cpu.TIME--;
                        this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value = Cpu.CX.Value;
                        break;
                    }
                case "LC":
                    {
                        Cpu.TIME--;
                        Cpu.CX.Value = this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value;
                        break;
                    }
                case "JM":
                    {
                        Cpu.TIME--;
                        Cpu.PC = Convert.ToInt16(operand, 16);
                        break;
                    }
                case "JE":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF == 1)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "JN":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF != 1)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "JA":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF == 0)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "JB":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF == 2)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "JG":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF == 0 || Cpu.SF == 1)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "JL":
                    {
                        Cpu.TIME--;
                        if (Cpu.SF == 1 || Cpu.SF == 2)
                            Cpu.PC = Convert.ToInt16(operand, 16);
                        else Cpu.PC++;
                        break;
                    }
                case "GD": //TO DO: everything
                    {
                        Cpu.TIME--;
                        //memory.Write(operand);
                        memory.Write(operand, vm.Io.Buffer);
                        vm.Io.Flush();
                        break;
                    }
                case "PD":
                    {
                        Cpu.TIME--;
                        string buf = string.Empty;
                        int block = Word.HexToInt(operand[0].ToString());
                        for (int i = 0; i < memory.WordCount; i++)
                        {
                            if (memory[block, i].Value != "----")
                                buf += memory[block, i].Value;
                        }
                        vm.Io.Buffer = buf;
                        vm.Io.WriteBuffer();
                        vm.Io.Flush();
                        break;
                    }
                case "--":
                    {
                        break;
                    }
                case "$E":
                    {
                        Cpu.TIME--;
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Unknown command: " + word.Value);
                    }             
            }
        }
    }
}
