using System;
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

        private static int divisibleBy4(int n)
        {
            var divide4 = n % 4;
            return divide4;
        }

        private static int divisibleBy5(int n)
        {
            var divide5 = n % 5;
            return divide5;
        }

        private static int divisibleBy7(int n)
        {
            var divide7 = n % 7;
            return divide7;
        }

        private static int divisibleBy9(int n)
        {
            var divide9 = n % 9;
            return divide9;
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

                if (divisibleBy4(n) == 0)
                {
                    Console.Write("bazz");
                    isDivisible = true;
                }


                if (divisibleBy5(n) == 0)
                {
                    Console.Write("bar");
                    isDivisible = true;
                }


                if (divisibleBy7(n) == 0)
                {
                    Console.Write("jazz");
                    isDivisible = true;
                }


                if (divisibleBy9(n) == 0)
                {
                    Console.Write("huzz");
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