using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Resources
{
    public enum Type { Gd, Pd, VMWorkFinish }

    public class InterruptInformation : Resource
    {
        public Type Type { get; set; }

        public InterruptInformation(Process creator, State state, string id, Type type, List<string> processList)
            : base(creator, state, id, processList)
        {
            Type = type;
        }
    }
}
