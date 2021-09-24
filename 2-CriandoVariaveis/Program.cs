using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - criando variaveis");

            string nomeCompleto;
            int    idade;
            nomeCompleto = "Giovani dos santos gama da silva";
            idade        = 19 + 20;
            Console.WriteLine(nomeCompleto + " | " + "idade: " + idade);

            Console.WriteLine("Execução finalizada. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
