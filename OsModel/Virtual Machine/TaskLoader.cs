using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OsModel.VirtualMachineEmulator
{
    public class TaskLoader    //Loads task into memory
    {
        private Memory memory;
        private string fileName;

        public Memory Memory
        {
            get { return memory; }
            
        }
        public TaskLoader(string fileName, Memory memory)
        {
            this.memory = memory;
            this.fileName = fileName;
        }

        public void Load()
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            var strings = File.ReadAllLines(fileName);
            int currentBlock = 0;
            int currentWord = 0;
            foreach (var line in strings)
            {
                switch (line.Substring(0, 2))
                {
                    case "$0":
                    {
                        currentBlock = Convert.ToInt32(line[2].ToString());
                        currentWord = 0;
                        break;
                    }
                    /*case "0x":
                    {
                        this.memory[currentBlock, currentWord].Value = line.Substring(2, line.Length - 2);
                        this.memory[currentBlock, currentWord].IsOccupied = true;
                        currentWord++;
                        break;
                    }*/
                    default:
                    {
                        this.memory[currentBlock, currentWord].Value = line.Length >= 4 ? line.Substring(0, 4) : line;
                        this.memory[currentBlock, currentWord].IsOccupied = true;
                        currentWord++;
                        break;
                    }
                }                 
            }
        }
    }
}
