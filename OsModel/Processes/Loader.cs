using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OsModel.Resources;
using OsModel.VirtualMachineEmulator;

namespace OsModel.Processes
{
    public class Loader : Process
    {
        Memory virtualMemory;
        UserMemory userMemory;
        Task task;
        int taskOffset;

        public Loader(int priority, State state, Process parentProcess, string id)
            : base(priority, state, parentProcess, id)
        {
            virtualMemory = new Memory(Memory.VIRTUAL_MEMORY_BLOCK_COUNT, Memory.BLOCK_WORD_COUNT);
        }

        private void Load(Task taskSource)
        {
            int currentBlock = 0;
            int currentWord = 0;
            for (int i = 0; i < 40; i++) //80 because virtual memory consists of 80 words
            {
                string line = taskSource[i];
                switch (line.Substring(0, 2))
                {
                    case "$0":
                        {
                            currentBlock = Convert.ToInt32(line[2].ToString());
                            currentWord = 0;
                            break;
                        }
                    case null:
                        {
                            break;
                        }
                    default:
                        {
                            virtualMemory[currentBlock, currentWord].Value = line.Length >= 4 ? line.Substring(0, 4) : line;
                            virtualMemory[currentBlock, currentWord].IsOccupied = true;
                            currentWord++;
                            break;
                        }
                }
            }
        }

        private void MapBlocks(int offset) //offset = [1|2|3]
        {
            int rmblock;
            for (int i = 0; i < 5; i++)
            {
                rmblock = Word.HexToInt(RealMachine.Memory[15, i].Value);
                for (int j = 0; j < Memory.BLOCK_WORD_COUNT; j++)
                {
                    userMemory[rmblock, j] = virtualMemory[i, j];
                }
            }
        }

        public override void Execute()
        {

            switch (Checkpoint)
            {
                case 1:
                    task = (Task) RequestResource("Task");
                    if (task == null)
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 2;
                case 2:
                    userMemory = (UserMemory) RequestResource("UserMemory");
                    if (userMemory == null)
                    {
                        break;
                    }
                    Checkpoint++;
                    goto case 3;
                case 3:
                    Load(task);
                    MapBlocks(1);
                    Checkpoint = 1;
                    break;
            }
        }
    }
}
