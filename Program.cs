using System;

namespace ShiftCipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Select the desired option: \n1.Ek\n2.Dk");
            int Select = Convert.ToInt32(Console.ReadLine());

            switch (Select)
            {
                case 1:

                    Console.WriteLine("enter your text: ");
                    string p0 = Console.ReadLine();
                    string p = p0.ToLower();
                    Console.WriteLine("enter your key: ");
                    int Key = Convert.ToInt32(Console.ReadLine());

                    Ek ek = new Ek
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

                    Dk dk = new Dk
                    {
                        Code = c,
                        key = key
                    };
                    dk.DkMethod();

                    break;

            }


        }




    }
}
