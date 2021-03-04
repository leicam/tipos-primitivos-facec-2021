using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos.TipoData
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = DateTime.MinValue;
            DateTime data2 = DateTime.MaxValue;
            DateTime data3 = DateTime.Now;
            DateTime data4 = DateTime.Today;
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;
            int ano = DateTime.Today.Year;
            DateTime data5 = DateTime.Now.AddMonths(1);
            DateTime data6 = DateTime.Now.AddMonths(-1);
            int data7 = DateTime.Now.Hour;

            Console.WriteLine("Valor Minimo DateTime:" + data1);
            Console.WriteLine("Valor Maximo DateTime:" + data2);
            Console.WriteLine("Valor de Data e Hora Atual:" + data3);
            Console.WriteLine("Valor Data Atual: " + data4);
            Console.WriteLine("Dia:" + dia);
            Console.WriteLine("Mês:" + mes);
            Console.WriteLine("Ano:" + ano);
            Console.WriteLine("Data atual + um mês:" + data5);
            Console.WriteLine("Data atual - um mês:" + data6);
            Console.WriteLine("Hora atual:" + data7);
            Console.WriteLine("Formato MM/dd/yyyy: " 
                + data4.ToString("MM/dd/yyyy"));
            Console.WriteLine("Formato dddd, dd, MMMM yyyy: "
                + data4.ToString("dddd, dd, MMMM yyyy"));
            Console.WriteLine(data4.ToLongDateString());
            Console.WriteLine(data3.ToLongTimeString());


            Console.ReadLine();
        }
    }
}
