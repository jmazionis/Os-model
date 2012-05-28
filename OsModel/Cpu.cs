using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.VirtualMachineEmulator;

namespace OsModel
{
    public static class Cpu
    {
        public static Registers Registers { get; set; }
        public const int PTR = 15;
        static Cpu()
        {
            Registers.AX = new Word(0); //Cannot modify the return value of 'OsModel.Cpu.Registers' because it is not a variable


        }
    }

    public struct Registers
    {
        public short PC { get; set; }
        public Word AX { get; set; }
        public Word CX { get; set; }
        public byte SF { get; set; }
        public WorkMode MODE { get; set; }
        public Int64 TIME { get; set; }
    }

    public enum WorkMode 
    {
        SUPERVISOR, USER
    }
}
