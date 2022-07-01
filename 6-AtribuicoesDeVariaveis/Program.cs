using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            string parcela1 = "10"; 
            string parcela2 = "20";

            Console.WriteLine(parcela1 + parcela2);

            Console.ReadLine();
        }
    }
}
