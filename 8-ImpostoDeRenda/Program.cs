using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3751.01;

            if (salario >= 0.01 && salario < 1900.00)
            {
                Console.WriteLine("O salário informado não entra na alíquota de Imposto de Renda.");
            }
            if (salario >= 1900.00 && salario <= 2800.00)
            {
                Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;");
            }
            if (salario >= 2800.01 && salario <= 3751.00)
            {
                Console.WriteLine("o IR é de 15% e pode deduzir R$ 350;");
            }
            if (salario >= 3751.01 && salario <= 4664.00)
            {
                Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636.");
            }

            Console.ReadLine();
        }
    }
}
