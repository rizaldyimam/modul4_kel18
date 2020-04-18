using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_4
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            string a;
            int x;
            Console.WriteLine("\nProgram Bilangan Prima Kelompok 18");
            Console.Write("Ada berapa bilangan prima yang anda ingin tampilkan ??\nBanyak : ");
            a = Console.ReadLine();
            int.TryParse(a, out x);
            if (x <= 1)
            {
                Console.WriteLine("Maaf, Tetapi bilangan prima terkecil adalah 2");
                Console.ReadKey();
                goto start;

            }
            else
            {
                Pendefinisi objek = new Pendefinisi();
                Console.WriteLine("Bilangan prima : ");
                objek.prima(x);
                goto start;
            }

        }
    }
}
