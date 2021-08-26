﻿using System;

namespace ShiftCipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Continue = 0;
            //Repeat program loop
            do
            {
                Console.WriteLine("Select the desired option: \n1.Encrypt\n2.Decrypt");
                int Select = Convert.ToInt32(Console.ReadLine());

                switch (Select)
                {
                    case 1:

                        Console.WriteLine("enter your text: ");
                        string p0 = Console.ReadLine();
                        string p = p0.ToLower();
                        Console.WriteLine("enter your key: ");
                        int Key = Convert.ToInt32(Console.ReadLine());

                        Encrypt ek = new Encrypt
                        {
                            key = Key,
                            p = p
                        };
                        ek.EkMethod();

                        break;

                    case 2:

                        Console.WriteLine("enter your text: ");
                        string c0 = Console.ReadLine();
                        string c = c0.ToLower();
                        Console.WriteLine("enter your key: ");
                        int key = Convert.ToInt32(Console.ReadLine());

                        Decrypt dk = new Decrypt
                        {
                            Code = c,
                            key = key
                        };
                        dk.DkMethod();

                        break;

                }

                Console.WriteLine();
                Console.WriteLine("Do you want to continue?\n1.Yes\n2.No");
                Continue = Convert.ToInt32(Console.ReadLine());

            } while (Continue==1);


        }




    }
}
