using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Tugas_4
{
    class Pendefinisi
    {
        public void prima(int n)
        {
            bool prima;
            int jumlah, i, nilai = 0;

            jumlah = 1;
            i = 2;

            while (jumlah <= n)
            {
                prima = true;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        prima = false;
                    }
                }

                if (prima == true)
                {
                    nilai = nilai + i;
                    Console.Write("{0} ", i);
                    jumlah++;
                }

                i++;
            }
            Console.WriteLine("\nJumlah Bilangan Prima yang telah di tampilkan adalah : {0}", nilai);
        }

    }
}
