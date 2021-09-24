using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Excecutando o projeto 5 - Carcteres e textos!");

            char primeiraLetra;
            primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);


            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo;
            string cursos;
            titulo = "A string serve para colocar um frase ou um texto";
            Console.WriteLine(titulo);

            cursos = @" - .net
 - excel
 - java";
            Console.WriteLine(cursos);

            Console.ReadLine();
        }
    }
}
