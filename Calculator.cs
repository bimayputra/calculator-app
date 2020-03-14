using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "aplikasi kalkulator";

            Console.Write("Inputkan Nilai a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inputkan Nilai b =");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("hasil penambahan" + a + "+" + b + "=" + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1}    ={2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1}      ={2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0}/{1}        ={2}", a, b, pembagian(a, b));
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
