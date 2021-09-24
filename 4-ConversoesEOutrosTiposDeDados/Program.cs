using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4. Conversão dos tipos de dados");

            double salario;
            salario = 1230.70;

            int salarioDesconto;
            salarioDesconto = (int)salario;
            Console.WriteLine(salarioDesconto);

            /* OUTROS TIPOS NUMERICOS */

            // long é uma variavel de 64 bits
            long idadeUniverso;
            idadeUniverso = 14000000000;
            Console.WriteLine(idadeUniverso);

            //short é um tipo de variavel de 16bits
            short idadePessoa;
            idadePessoa = 100;
            Console.WriteLine(idadePessoa);

            //float tem uma precisão menor do que o double e precisa sufiquiso f
            float salarioTeste;
            salarioTeste = 1240.30f;
            Console.WriteLine(salarioTeste);


            Console.WriteLine("Aperte enter para encerrar...");
            Console.ReadLine();
        }
    }
}
