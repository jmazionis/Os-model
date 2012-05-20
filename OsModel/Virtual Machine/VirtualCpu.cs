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
            int block = this.PC / 16;
            int word = this.PC % 16;
            if (!(this.memory[block, word].Value == "$END"))
            {
                if (this.memory[block, word].Value == "----")
                {
                    FindNextCommand();
                    return true;
                }
                this.ExecuteCommand(this.memory[block, word]);
                if (!(this.memory[block, word].Value[0] == 'J'))
                    this.PC++;
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
                PC++;
                if (this.memory[PC / 16, PC % 16].Value != "----")
                    return;
            }
        }


        public string NextCommand()
        {
            return this.memory[PC / 16, PC % 16].Value;
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
                        this.AX = this.AX + this.CX;
                        break;
                    }
                case "SU":
                    {
                        this.AX = this.AX - this.CX;
                        break;
                    }
                case "CM":
                    {
                        if (this.AX > this.CX)
                            this.SF = 0;
                        if (this.AX < this.CX)
                            this.SF = 2;
                        if (Word.HexToInt(this.AX.Value) == Word.HexToInt(this.CX.Value))
                            this.SF = 1;
                        break;
                    }
                case "SA":
                    {
                        this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value = this.AX.Value;
                        break;
                    }
                case "LA":
                    {
                        this.AX.Value = this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value;
                        break;
                    }
                case "SC":
                    {
                        this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value = this.CX.Value;
                        break;
                    }
                case "LC":
                    {
                        this.CX.Value = this.memory[Convert.ToInt32(operand[0].ToString(), 16), Convert.ToInt32(operand[1].ToString(), 16)].Value;
                        break;
                    }
                case "JM":
                    {
                        this.PC = Convert.ToInt16(operand, 16);
                        break;
                    }
                case "JE":
                    {
                        if (this.SF == 1)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "JN":
                    {
                        if (this.SF != 1)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "JA":
                    {
                        if (this.SF == 0)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "JB":
                    {
                        if (this.SF == 2)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "JG":
                    {
                        if (this.SF == 0 || this.SF == 1)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "JL":
                    {
                        if (this.SF == 1 || this.SF == 2)
                            this.PC = Convert.ToInt16(operand, 16);
                        else this.PC++;
                        break;
                    }
                case "GD": //TO DO: everything
                    {
                        //memory.Write(operand);
                        memory.Write(operand, vm.Io.Buffer);
                        vm.Io.Flush();
                        break;
                    }
                case "PD":
                    {
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
