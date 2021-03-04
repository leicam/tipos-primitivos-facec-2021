using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.ExercicioII
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Por favor, informe sua altura: ");
                var altura = Console.ReadLine().ToDecimal();
                Console.WriteLine("Por favor, informe seu peso: ");
                var peso = Console.ReadLine().ToDecimal();

                Console.WriteLine(GetMeuICM(altura, peso));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static string GetMeuICM(decimal altura, decimal peso)
        {
            var imc = Math.Round(peso / (altura * altura), 2);

            if (imc <= 18.5m)
                return $"Abaixo do peso ideal. IMC:{imc}";
            else if (imc >= 24.9m)
                return $"Acima do peso ideal. IMC: {imc}";

            return $"Com peso ideal. IMC: {imc}";
        }
    }

    internal static class StringExtensions
    {
        internal static decimal ToDecimal(this string value)
            => decimal.Parse(value);
    }
}
