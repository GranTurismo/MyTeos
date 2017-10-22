using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeos
{
    class Program
    {
        static void ended(int a)
        {
            Console.Clear();
            if (a == 1)
            {
                Main();
            }
            else
            {
                return;
            }
        }
        static void check(int cda, int fqr, int input)
        {
                if (input == fqr && cda==6)
                {
                    Console.WriteLine("Sheudzlebelia! Tqven Pirvelive Cdaze Gamoicanit! Es Ricxvi Iyo {0}\n - - -", fqr);
                Console.WriteLine("Tu Gsurt Tavidan Cda Chaweret 1,Tu Gsurt Programis Daxurva Chaweret 0\n - - -");
                ended(Convert.ToInt32(Console.ReadLine()));
            }
                else if(input==fqr && cda < 6)
            {
                Console.WriteLine("Tqven Gamoicanit! Diax,Es Ricxvi Iyo {0}\n - - - ", fqr);
                Console.WriteLine("Tu Gsurt Tavidan Cda Chaweret 1,Tu Gsurt Programis Daxurva Chaweret 0\n - - - ");
                    ended(Convert.ToInt32(Console.ReadLine()));
            }
                else if (input < fqr)
                {
                    cda--;
                    Console.WriteLine("Chafiqrebuli Ricxvi Metia {0}-Ze\n - - - ", input);
                    mtv(cda, fqr);
                }
                else
                {
                    cda--;
                    Console.WriteLine("Chafiqrebuli Ricxvi Naklebia {0}-Ze\n - - - ", input);
                    mtv(cda, fqr);
                }
            }
        static void mtv(int cda, int fqr)
        {
            if (cda == 6)
            {
                Console.WriteLine("Tqven Gaqvt {0} Cda,Warmatebebs Gisurvebt!\n - - - ", cda);
            }
            else if(cda>0)
            {
                Console.WriteLine("Tqven Darchenili Gaqvt {0} Cda\n - - - ", cda);
            }
            else
            {
                Console.WriteLine("Tqven Waaget,Chafiqrebuli Ricxvi Iyo {0}\n - - - ", fqr);
                Console.WriteLine("Tu Gsurt Tavidan Cda Chaweret 1,Tu Gsurt Programis Daxurva Chaweret 0\n - - - ");
                ended(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Shemoitanet Ricxvi\n - - - ");
            int input = Convert.ToInt32(Console.ReadLine());
            check(cda, fqr, input);
        }
        static void Main()
        {
            Random rand = new Random();
            int fqr = rand.Next(100);
            int cda = 6;
            Console.WriteLine("Kompiuterma Chaifiqra Ricxvi 0-Dan 99-Is Chatvlit.Gamoicanit Igi\n - - - ");

            mtv(cda, fqr);
        }
    }
}
