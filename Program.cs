using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCipher
{
    class Program
    {
        static void Main(string[] args)
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
                    
                    var ek = new Ek();
                    ek.key = Key;
                    ek.p = p;
                    ek.EkMethod();

                    break;

                case 2:

                    Console.WriteLine("enter your text: ");
                    string c0 = Console.ReadLine();
                    string c = c0.ToLower();
                    Console.WriteLine("enter your key: ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    var dk = new Dk();
                    dk.Code = c;
                    dk.key = key;
                    dk.DkMethod();

                    break;

            }


        }

        

        
    }
}
