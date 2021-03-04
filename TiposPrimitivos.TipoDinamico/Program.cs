using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte1 = 1;
            byte byte2 = 255;
            char char1 = 'J';

            object objeto1 = 1;
            dynamic dinamico1 = 1;

            //objeto1 = objeto1 + 1; erro em tempo de execução
            dinamico1 = dinamico1 + 1;

            //objeto1 = "Olá Mundo";
            //dinamico1 = "Olá Mundo";

            Console.WriteLine($"Tipo da variavel objeto1 {objeto1.GetType()}");
            Console.WriteLine($"Tipo da variavel dinamico1 {dinamico1.GetType()}");
            Console.ReadLine();
        }
    }
}