using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando pojeto 9 - Escopo");

            int idadeGiovani = 20;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "Giovani está acompanhado";
            }
            else
                mensagemAdicional = "Giovani não está acompanhado";



            if (idadeGiovani >= 18 && acompanhado == true)
            {
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine(mensagemAdicional);

            }

            int idade = 68;
            bool ehIdoso = idade >= 65;
            Console.WriteLine(ehIdoso);

            Console.ReadLine();
        }
    }
}
