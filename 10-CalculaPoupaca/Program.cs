using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;
            // 0.36% = 0.0036
            /*
            valorInvestido = valorInvestido + (valorInvestido * (0.36 / 100));
            Console.WriteLine("Após um mês, você terá  R$ " + valorInvestido);
            */
            int contadorMes = 1;
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * (0.36 / 100));
                Console.WriteLine("Após " + contadorMes + " meses, você terá  R$" + valorInvestido);
                contadorMes += 1;
            }
            Console.ReadLine();
        }
    }
}
