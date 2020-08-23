using System;

namespace ShiftCipher
{
    public class Dk
    {
        public string Code;
        public int key;

        public Dk() { }

        public void DkMethod()
        {
            char[] Alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string code = Code;
            int length = code.Length;

            int[] NumberOfLetters = new int[length];
            char[] text = new char[length];

            // پیدا کردن شماره های کل متن
            for (int i = 0; i < length; i++)
            {
                char temp = code[i];
                // پیدا کردن شماره هر حرف
                for (int j = 0; j < 26; j++)
                {   //Alphabet[j] == temp
                    if (temp.Equals(Alphabet[j]))
                    {
                        NumberOfLetters[i] = j;

                    }
                }
            }

            //تبدیل اعداد
            for (int i = 0; i < length; i++)
            {
                NumberOfLetters[i] -= key;
                if (NumberOfLetters[i] < 0)
                {
                    NumberOfLetters[i] += 26;
                }
            }

            //تبدیل عدد به حرف
            for (int i = 0; i < length; i++)
            {
                text[i] = Alphabet[NumberOfLetters[i]];
            }

            //چاپ متن رمز شده
            Console.WriteLine("your code is: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine();
        }

    }
}
