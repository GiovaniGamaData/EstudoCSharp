using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPoupaca2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double valorInvestido = 10000;

            for (int contadorMes = 1; contadorMes <=12; contadorMes++)
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá  R$" + valorInvestido);
            }


            Console.ReadLine();
        }
    }
}
