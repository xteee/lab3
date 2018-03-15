using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        public static int add(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Введите А: ");
            a = Console.Read();

            Console.WriteLine("\nВведите В: ");
            b = Console.Read();

            Console.WriteLine("1.Выролнить операцию (+) " + "\n2.Выполнить операцию (-)" + "\n3.Выполнить операцию(*)" + "\n4.Выполнить операцию (/)");

            int c;
            c = Console.Read();
            switch (c)
            {
                case 1:
                    //+
                    
                    break;

                case 2:
                    //-

                    break;

                case 3:
                    // *

                    break;

                case 4:


                    break;





            }


        }
    }
}
