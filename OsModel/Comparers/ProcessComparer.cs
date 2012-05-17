using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Processes;

namespace OsModel.Comparers
{
    public class ProcessComparer : IComparer<Process>
    {
        public int Compare(Process x, Process y)
        {
            return x.Priority - y.Priority;
        }
    }
}
