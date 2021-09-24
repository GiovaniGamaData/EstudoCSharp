using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando pojeto 8 - Condicionais2");

            int idadeGiovani = 20;
            //int quantidadePessoas = 5;
            //bool acompanhado = (quantidadePessoas >= 2);
            bool acompanhado = true;

            if (idadeGiovani >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("não pode entrar");

            }

            int idade = 68;
            bool ehIdoso = idade >= 65;
            Console.WriteLine(ehIdoso);

            Console.ReadLine();
        }
    }
}
