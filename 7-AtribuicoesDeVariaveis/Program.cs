using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando pojeto 7 - Condicionais");

            int idadeGiovani = 17;
            int quantidadePessoas = 2;

            if (idadeGiovani >= 18)
            {
                Console.WriteLine("O Giovani é maior de idade");
            }
            else if (quantidadePessoas >= 2)
            {
                Console.WriteLine("Giovani é de menor, mas está acompanhado");
            }
            else
            {
                Console.WriteLine("O Giovani é menor de idade e não está acompanhado");

            }

            Console.ReadLine();
        }
    }
}
