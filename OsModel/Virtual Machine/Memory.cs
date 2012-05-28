namespace OsModel.VirtualMachineEmulator
{

    public class Memory
    {
        private Word[,] words;
        public const int BLOCK_WORD_COUNT = 16;
        public const int REAL_MEMORY_BLOCK_COUNT = 16;
        public const int VIRTUAL_MEMORY_BLOCK_COUNT = 5;

        public Memory(int blockCount, int wordCount)
        {
            this.words = new Word[blockCount, wordCount];
            for (int i = 0; i < this.words.GetLength(0); i++)
            {
                for (int j = 0; j < this.words.GetLength(1); j++)
                {
                    this.words[i, j] = new Word();
                }
            }
        }

        public int BlockCount 
        { 
            get { return this.words.GetLength(0); }
        }

        public int WordCount
        {
            get { return this.words.GetLength(1); }
        }

        public Word this[int block, int word]
        {
            set { words[block, word] = value; }
            get { return words[block, word]; }
        }

        public void Write(string operand, string buffer)
        {
            int block = Word.HexToInt(operand[0].ToString());
            Word[] words = StringToWords(buffer);
            for (int i = 0; i < words.Length; i++)
                this.words[block, i] = words[i];
        }

        private Word[] StringToWords(string s)
        {
            if (s == null)
            {
                return null;
            }
            int wordCount = s.Length / 4;
            Word[] words = new Word[wordCount];
            for (int i = 0; i < wordCount; i++)
            {
                words[i] = new Word(s.Substring(i * 4, 4));
            }
            string remaining = s.Substring(s.Length - s.Length % 4);
            if (remaining.Length > 0)
            {
                Word[] allWords = new Word[wordCount + 1];
                words.CopyTo(allWords, 0);
                allWords[allWords.Length - 1] = new Word(remaining);
                return allWords;
            }
            else
            {
                return words;
            }
        }
        
    }
}
