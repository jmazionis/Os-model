using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Resources
{
    public class SupervisorMemory : Resource
    {
        string[] Memory = new string[100];

        public SupervisorMemory(Process creator, State state, string id, List<string> processList)
            : base(creator, state, id, processList)
        {

        }

        public string this[int i]
        {
            get
            {
                return Memory[i];
            }

            set
            {
                Memory[i] = value;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Memory.Length; i++)
            {
                Memory[i] = null;
            }
        }   
    }
}
