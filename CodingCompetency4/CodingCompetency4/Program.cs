using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class myClass
    {

        public static void showData(int data, int input, string output)
        {
            for (var n = 1; n <= data; n++)
            {
                var isDivisible = false;

                if ((n % input) == 0)
                {
                    Console.Write(output);
                    isDivisible = true;
                }

                if (isDivisible)
                    Console.WriteLine();
                else
                    Console.WriteLine(n);
            }
        }
    }

    class Foobar
    {
        static void Main()
        {
            Console.WriteLine("Silahkan masukan jumlah data yang ingin ditampilkan :");
            var data = Console.ReadLine();
            Console.WriteLine("Silahkan masukan input rule yang diinginkan :");
            var input = Console.ReadLine();
            Console.WriteLine("Silahkan masukan output rule yang diinginkan :");
            var output = Console.ReadLine();
            myClass.showData(int.Parse(data), int.Parse(input), output);
            Console.ReadLine();
        }
    }
}