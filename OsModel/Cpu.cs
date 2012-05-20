using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.VirtualMachineEmulator;

namespace OsModel
{
    public class Cpu
    {
        public short PC { get; set; }
        public Word AX { get; set; }
        public Word CX { get; set; }
        public Word PTR { get; set; }
        public byte SF { get; set; }
        public WorkMode MODE { get; set; }
        public Int64 TIME { get; set; }

    }

    enum WorkMode 
    {
        SUPERVISOR, USER
    }
}
