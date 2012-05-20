using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OsModel.VirtualMachineEmulator
{
    public static class RealMachine
    {
        public static Memory Memory;
        public static int PTR;
        public static int PTRBlockNumber;
        public static int[] PageTable;

        static RealMachine()
        {
            Memory = new Memory(Memory.REAL_MEMORY_BLOCK_COUNT, Memory.BLOCK_WORD_COUNT);
            PTR = 15;
            PageTable = new int[Memory.REAL_MEMORY_BLOCK_COUNT];
            InitializePageTable();
        }

        private static void InitializePageTable()
        {
            int[] array = new int[Memory.REAL_MEMORY_BLOCK_COUNT - 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Shuffle(array);
            for (int i = 0; i < array.Length; i++)
            {
                PageTable[i] = array[i];
                Memory[PTR, i].Value = PageTable[i].ToString("X");
            }
        }

        private static void Shuffle(int[] array)
        {
            var random = new Random();
            int n, temp;
            for (int i = array.Length - 1; i > 0; i--)
            {
                n = random.Next(i + 1);
                temp = array[i];
                array[i] = array[n];
                array[n] = temp;
            }
        }
    }
}
