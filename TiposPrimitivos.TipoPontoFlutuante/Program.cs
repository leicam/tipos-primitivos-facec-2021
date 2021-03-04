using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            float float1 = float.MinValue;
            float float2 = float.MaxValue;

            double double1 = double.MinValue;
            double double2 = double.MaxValue;

            decimal decimal1 = decimal.MinValue;
            decimal decimal2 = decimal.MaxValue;

            double valorDouble1 = 10.10f;
            double valorDouble2 = 20.20f;
            double valorDoubleTotal = 30.30f;
            double valorResultadoSomaDouble = valorDouble1 + valorDouble2;

            decimal valorDecimal1 = 10.10m;
            decimal valorDecimal2 = 20.20m;
            decimal valorDecimalTotal = 30.30m;
            decimal valorResultadoSomaDecimal = valorDecimal1 + valorDecimal2;

            //Console.WriteLine("Valor Minimo Float:" + float1);
            //Console.WriteLine("Valor Maximo Float:" + float2);
            //Console.WriteLine("\n");
            //Console.WriteLine("Valor Minimo Double:" + double1);
            //Console.WriteLine("Valor Maximo Double:" + double2);
            //Console.WriteLine("\n");
            //Console.WriteLine("Valor Minimo Decimal:" + decimal1);
            //Console.WriteLine("Valor Maximo Decimal:" + decimal2);
            //Console.WriteLine($"{valorDouble1 + valorDouble2} = {valorDoubleTotal}");
            //Console.WriteLine($"{valorDouble1 + valorDouble2} = {valorResultadoSomaDouble}");
            //Console.WriteLine((valorDouble1 + valorDouble2) == valorDoubleTotal);

            Console.WriteLine($"{valorDecimal1 + valorDecimal2} = {valorDecimalTotal}");
            Console.WriteLine($"{valorDecimal1 + valorDecimal2} = {valorResultadoSomaDecimal}");
            Console.WriteLine(valorResultadoSomaDecimal == valorDecimalTotal);

            Console.ReadLine();
        }
    }
}
