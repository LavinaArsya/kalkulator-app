using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            displayOpt();
            Console.Title = "Aplikasi Calculator";
            int opt = int.Parse(Console.ReadLine());

            Console.WriteLine("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)

            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            } else if (opt == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            } else if (opt == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} + {2}", a, b, Perkalian(a, b));
            } else if (opt == 4)

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\n tekan sembarang tombol");
            Console.ReadKey();
        }


        static void displayOpt()
        {
            Console.WriteLine("pilih operasi :");
            Console.WriteLine(" 1. penambahan :");
            Console.WriteLine(" 2. pengurangan :");
            Console.WriteLine(" 3. perkalian :");
            Console.WriteLine(" 4. pembagian :");
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return (a / b);
        }
        
    }
}
