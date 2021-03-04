using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isPar = (DateTime.Today.Day % 2) == 0;

            //if (isPar)
            //    Console.WriteLine("Valor bool == true");
            //else
            //    Console.WriteLine("Valor bool == false");

            Console.WriteLine(IsDiaPar() ? "Valor bool == true" : "Valor bool == false");
            Console.ReadLine();
        }

        private static bool IsDiaPar()
        {
            return (DateTime.Today.Day % 2) == 0;
        }
    }
}
