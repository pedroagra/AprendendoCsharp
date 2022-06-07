using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2022;
            string cursosProgramacao = " - .NET" +
                "- Java" +
                "- Javascript";

            string cursosProgramacao2 = 
@"- .NET
- Java 
- Javascript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.WriteLine(cursosProgramacao2);

            string vazia = "";

            


            Console.ReadLine();
        }
    }
}
