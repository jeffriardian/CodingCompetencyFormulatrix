﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class FooBar
    {
        static void Main()
        {
            Console.WriteLine("Masukan jumlah data :");
            var numberOfElements = Console.ReadLine();
            foobar(int.Parse(numberOfElements));
            Console.ReadLine();
        }

        private static int divisibleBy3(int n)
        {
            var divide3 = n % 3;
            return divide3;
        }

        private static int divisibleBy5(int n)
        {
            var divide5 = n % 5;
            return divide5;
        }

        public static void foobar(int numberOfElements)
        {
            for (var n = 1; n <= numberOfElements; n++)
            {

                var isDivisible = false;

                if (divisibleBy3(n) == 0)
                {
                    Console.Write("foo");
                    isDivisible = true;
                }


                if (divisibleBy5(n) == 0)
                {
                    Console.Write("bar");
                    isDivisible = true;
                }

                if (isDivisible)
                    Console.WriteLine();
                else
                    Console.WriteLine(n);
            }
        }
    }
}