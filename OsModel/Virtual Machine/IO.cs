using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsModel.VirtualMachineEmulator
{
    public delegate void VMEventHandler();
    public class IO
    {
        
        private string buffer;
		public const int BUFF_SIZE = 16;
		public event VMEventHandler OutputRequested;
		public event VMEventHandler InputRequested;

		public string Buffer 
        {
			set 
            {
                buffer = value.Length > BUFF_SIZE * 4 ? value.Substring(0, BUFF_SIZE) : value;
			}
            get 
            {
				return buffer;
			}
		}

		public void Flush() {
			buffer = "";
		}

		public void WriteBuffer() {
			OutputRequested();			
		}

		public void ReadBuffer() {
			InputRequested();			
		}
	}

}

