using System;

namespace ShiftCipher
{
    public class Encrypt
    {
        public string p;
        public int key;

        public Encrypt(string P, int Key)
        {
            p = P;
            key = Key;
        }

        public Encrypt() { }


        public void EkMethod()
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string text = p;
            int length = text.Length;

            int[] NumberOfLetters = new int[length];
            char[] Code = new char[length];

            // Find whole text numbers
            for (int i = 0; i < length; i++)
            {
                char temp = text[i];
                // Find the number of each letter
                for (int j = 0; j < 26; j++)
                {   //Alphabet[j] == temp
                    if (temp.Equals(Alphabet[j]))
                    {
                        NumberOfLetters[i] = j;

                    }
                }
            }

            //Convert numbers
            for (int i = 0; i < length; i++)
            {
                NumberOfLetters[i] += key;
                if (NumberOfLetters[i] > 25)
                {
                    NumberOfLetters[i] -= 26;
                }
            }

            //Convert numbers to letters
            for (int i = 0; i < length; i++)
            {
                Code[i] = Alphabet[NumberOfLetters[i]];
            }

            //Print encrypted text
            Console.WriteLine("your code is: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(Code[i]);
            }
            Console.WriteLine();
        }
    }
}
