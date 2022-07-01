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
            Console.WriteLine("Executando Projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 5200.70;

            Console.WriteLine("Meu salário é: " + salario + ". Dev .Net Backend!!!");

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("O resultado de [15.0] / {2} COM o (.) ponto decimal é: " + idade);
            idade = 15 / 2;
            Console.WriteLine("O resultado de 15 / 2 sem o (.) ponto decimal é: " + idade);

            idade = 5.0 / 3;
            Console.WriteLine(idade);

            double peso = 2.0;
            int quantidade = 10;
            Console.WriteLine(quantidade / peso);

            peso = 4.33;
            quantidade = 10;
            Console.WriteLine(peso * quantidade);

            peso = 4.0;
            quantidade = 10;
            Console.WriteLine(peso * quantidade);

            double divisao = 5 / 2;
            Console.WriteLine(divisao);

            double peso1 = 4.0;
            int quantidade1 = 10;
            Console.WriteLine(peso1 * quantidade1 + " Deve imprimir 40");

            double preco = 5.5;
            int ingressos = 4;
            Console.WriteLine(preco * ingressos + " sDeve imprimir 22"); 

            Console.WriteLine("A execução acabou. Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
