using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Anna luku:");
           
            //Int32.TryParse(input, out luku);
            try
            {
               string input = Console.ReadLine();
               TulostaKertotaulu(int.Parse(input));

               
                {
                 throw new Exception("Virheellinen luku");
                }

            }
            catch 
            {
                Console.WriteLine("Virheellinen luku");
            }
            

        }

        private static void TulostaKertotaulu(int luku)
        {
            for (int i = 1; i <= 10; i++)
            {
                int tulo = luku * i;
                Console.WriteLine("{0} * {1} = {2}", luku, i, tulo);
            }
            Console.WriteLine();
        }
    }
}
