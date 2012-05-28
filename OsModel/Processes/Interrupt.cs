using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;

namespace OsModel.Processes
{
    public class Interrupt : Process
    {
        InterruptInformation interruptInformation;

        public Interrupt(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {

        }

        public override void Execute() //TODO: finish implementation
        {
            interruptInformation = (InterruptInformation) RequestResource("InterruptInformation");
            if (interruptInformation != null)
            {
                switch (interruptInformation.Type)
                {
                    case Resources.Type.Gd:
                        break;
                    case Resources.Type.Pd:
                        break;
                    case Resources.Type.VMWorkFinish:
                        break;
                }
            }           
        }
    }
}
