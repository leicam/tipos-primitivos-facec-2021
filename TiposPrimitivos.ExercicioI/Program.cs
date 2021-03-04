using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.ExercicioI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Por favor, informe seu ano de nascimento:");
                Console.WriteLine($"Sua idade é: {DateTime.Today.Year - Console.ReadLine().ToInt()}");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this string value) => int.Parse(value);
    }
}
