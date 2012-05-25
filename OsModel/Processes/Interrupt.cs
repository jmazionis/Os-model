using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsModel.Processes
{
    public class Interrupt : Process
    {

        public Interrupt(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {

        }

        public override void Execute()
        {

        }
    }
}
