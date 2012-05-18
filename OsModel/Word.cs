using System;

namespace OsModel.VirtualMachineEmulator
{
    public class Word{
    
        public string Value { get; set; }
        public bool IsOccupied { get; set; }

        public Word()
        {
            this.Value = "----";
        }

        public Word(string value)
        {
            this.Value = value;
        }

        public Word(int value)
            : this(value.ToString())
        {
        }

        public static Word operator +(Word word1, Word word2)
        {
            Int16 op1, op2, sum;
            try
            {
                op1 = HexToInt(word1.Value);
                op2 = HexToInt(word2.Value);
                sum = (Int16)(op1 + op2);
                /*
                 * Neaisku ar cia taip reikia
                if (sum != (int)(op1 + op2))
                    sum -= HexToInt("7FFF");
                 */
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(sum.ToString("X"));
        }

        public static Word operator -(Word word1, Word word2)
        {
            Int16 op1, op2, difference;
            try
            {
                op1 = HexToInt(word1.Value);
                op2 = HexToInt(word2.Value);
                difference = (Int16)(op1 - op2);
                /*
                 * Neaisku ar cia taip reikia
                 * if (difference != (int)(op1 - op2))
                    difference += HexToInt("7FFF");
                 */
            }
            catch (Exception)
            {
                throw;
            }
            return new Word(difference.ToString("X"));
        }

        public static bool operator >(Word word1, Word word2)
        {
            Int16 op1, op2;
            try
            {
                op1 = HexToInt(word1.Value);
                op2 = HexToInt(word2.Value);
            }
            catch (Exception)
            {
                throw;
            }
            return op1 > op2;
        }

        public static bool operator <(Word word1, Word word2)
        {
            Int16 op1, op2;
            try
            {
                op1 = HexToInt(word1.Value);
                op2 = HexToInt(word2.Value);
            }
            catch (Exception)
            {
                throw;
            }
            return op1 < op2;
        }

        public static Int16 HexToInt(string number)
        {
            //int numb = Convert.ToInt16(number, 16);
            return Convert.ToInt16(number, 16);
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
