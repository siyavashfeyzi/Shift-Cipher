using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCipher
{
   public class Ek
    {
        public string p;
        public int key;

        public Ek(string P, int Key) 
        {
            p = P;
            key = Key;
        }

        public Ek(){ }
        

        public void EkMethod() 
        {
            char[] Alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y','z'};
            
            string text = p;
            int length = text.Length;

            int[] NumberOfLetters = new int[length];
            char[] Code = new char[length];

            // پیدا کردن شماره های کل متن
            for (int i = 0; i < length; i++) 
            {
                char temp = text[i];
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
                NumberOfLetters[i] += key;
                if (NumberOfLetters[i] > 25) 
                {
                    NumberOfLetters[i] -= 26;
                }
            }

            //تبدیل عدد به حرف
            for (int i = 0; i < length; i++)
            {
                Code[i] = Alphabet[NumberOfLetters[i]];
            }

            //چاپ متن رمز شده
            Console.WriteLine("your code is: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write(Code[i]);
            }
            Console.WriteLine();
        } 
    }
}
