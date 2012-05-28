using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.VirtualMachineEmulator;

namespace OsModel
{
    public static class Cpu
    {
        public const int PTR = 15;
        public static short PC { get; set; }
        public static Word AX { get; set; }
        public static Word CX { get; set; }
        public static byte SF { get; set; }
        public static WorkMode MODE { get; set; }
        public static int TIME { get; set; }
        static Cpu()
        {
            TIME = PC = SF = 0;
            AX = new Word(0); 
            CX = new Word(0);
            MODE = WorkMode.SUPERVISOR;

        }
    }

    public struct Registers
    {
        
    }

    public enum WorkMode 
    {
        SUPERVISOR, USER
    }
}
