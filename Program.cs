using System;

namespace ShiftCipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Key;
            string Text;
            string Code;
            string answer;
            ConsoleKey response;
            bool Continues = false;
            
            //Repeat program loop
            do
            {
                Console.WriteLine("Select the desired option Encrypt or Decrypt? [e/d]");
                string Select = Console.ReadLine().ToLower();

                switch (Select)
                {
                    case "e":

                        Console.WriteLine("enter your text: ");
                        Text = Console.ReadLine().ToLower();

                        Console.WriteLine("enter your key: ");
                        Key = Convert.ToInt32(Console.ReadLine());

                        answer = Caesar_Cipher.Encrypt(Text, Key);
                        Console.WriteLine(answer);
                        break;

                    case "d":

                        Console.WriteLine("enter your text: ");
                        Code = Console.ReadLine().ToLower();

                        Console.WriteLine("enter your key: ");
                        Key = Convert.ToInt32(Console.ReadLine());

                        answer = Caesar_Cipher.Decrypt(Code, Key);
                        Console.WriteLine(answer);
                        break;

                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue? [y/n]");
                response = Console.ReadKey(true).Key;

                Continues = response == ConsoleKey.Y ? true : false;

            } while (Continues);

        }

    }
}
