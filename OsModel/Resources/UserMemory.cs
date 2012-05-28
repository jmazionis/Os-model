using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Resources
{
    public class UserMemory : Resource
    {
        public const int BlockOffset = 3;
        public UserMemory(Process creator, State state, string id, List<string> processList)
            : base(creator, state, id, processList)
        {
        }

        public Word this[int block, int word]
        {
            get
            {
                return RealMachine.Memory[block, word];
            }
            set
            {
                RealMachine.Memory[block, word] = value;
            }
        }


    }
}
