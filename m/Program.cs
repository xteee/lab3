﻿using System;
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

        public static int minus(int a, int b)
        {
            return a - b;
        }
        public static int umnoj(int a, int b)
        {
            return a * b;
        }
        public static int dilit(int a, int b)
        {
            return a / b;
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
                    
                    add(a, b);
                    break;

                case 2:
                    minus(a, b);
                    break;

                case 3:
                    // *
                    umnoj(a, b);
                    break;

                case 4:
                    dilit(a, b);

                    break;





            }


        }
    }
}
