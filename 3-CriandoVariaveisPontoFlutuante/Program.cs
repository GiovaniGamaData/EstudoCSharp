using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3. Criando variaveis de ponto Flutuante");

            double salario;
            salario = 1200.98;
            Console.WriteLine("O seu salario é de: " + salario);
            if(salario <= 1000)
            {
                Console.WriteLine("Salario baixo, nivel estagio...");
            }
            else
            {
                Console.WriteLine("SALARIO OK...");
            }

            Console.WriteLine("A execução acabou. Aperte enter para fechar...");
            Console.ReadLine();
        }
    }
}
