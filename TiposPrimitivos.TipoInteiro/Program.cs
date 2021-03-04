using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoInteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            short short1 = short.MinValue;
            short short2 = short.MaxValue;

            ushort ushort1 = ushort.MinValue;
            ushort ushort2 = ushort.MaxValue;

            int int1 = int.MinValue;
            int int2 = int.MaxValue;

            uint uint1 = uint.MinValue;
            uint uint2 = uint.MaxValue;

            long long1 = long.MinValue;
            long long2 = long.MaxValue;

            ulong ulong1 = ulong.MinValue;
            ulong ulong2 = ulong.MaxValue;

            Console.WriteLine("Valor Minimo do short:" + short1);
            Console.WriteLine("Valor Maximo do short:" + short2);
            Console.WriteLine("\n");
            Console.WriteLine("Valor Minimo do ushort:" + ushort1);
            Console.WriteLine("Valor Maximo do ushort:" + ushort2);
            Console.WriteLine("\n");
            Console.WriteLine("Valor Minimo do int:" + int1);
            Console.WriteLine("Valor Maximo do int:" + int2);
            Console.WriteLine("\n");
            Console.WriteLine("Valor Minimo do uint:" + uint1);
            Console.WriteLine("Valor Maximo do uint:" + uint2);
            Console.WriteLine("\n");
            Console.WriteLine("Valor Minimo do long:" + long1);
            Console.WriteLine("Valor Maximo do long:" + long2);
            Console.WriteLine("\n");
            Console.WriteLine("Valor Minimo do ulong:" + ulong1);
            Console.WriteLine("Valor Maximo do ulong:" + ulong2);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}