using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro1;
            decimal decimal1;
            string string1;

            Console.WriteLine("Por favor digite um número: ");
            string1 = Console.ReadLine();
            //int1 = Console.ReadLine();

            //Console.WriteLine(decimal.Parse(string1).GetType());
            decimal.TryParse(string1, out decimal1);
            int.TryParse(string1, out inteiro1);

            Console.WriteLine($"Valor Convertido Decimal: {decimal1}");
            Console.WriteLine($"Valor Convertido Inteiro: {inteiro1}");
            Console.ReadLine();
        }
    }
}