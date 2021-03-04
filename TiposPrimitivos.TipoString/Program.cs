using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoString
{
    class Program
    {
        static void Main(string[] args)
        {
            String string1 = null;
            string string2 = null;
            //string string3 = "Olá meu nome é: ";
            //string string4 = Console.ReadLine();
            //Console.WriteLine(string3 + string4);

            //Console.WriteLine("Olá meu nome é: " 
            //    + Console.ReadLine());
            string string5 = "Bem vindo! ";
            string string6 = "Por favor digite seu nome:";
            string string7 = "Por favor digite seu sobrenome:";
            string string8 = "Olá: {0} {1}";
            
            Console.WriteLine(string5);
            Console.WriteLine(string6);
            string string9 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(string9))
            {
                Console.WriteLine("Valor informado é inválido!");
                return;
            }

            Console.WriteLine(string7);
            string string10 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(string10))
            {
                Console.WriteLine("Valor informado é inválido!");
                return;
            }

            else
                Console.WriteLine(string8, string9, string10);

            Console.ReadLine();
        }
    }
}
