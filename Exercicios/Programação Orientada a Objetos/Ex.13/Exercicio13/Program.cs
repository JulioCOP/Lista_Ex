using Exercicio13;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            Console.Write("Informe o salario bruto (CTPS) do funcionário R$: ");
            func.SalarioBruto= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a % do imposto descontada de seu salário: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(" FUNCIONÁRIO: " + func);

            Console.Write($"Informe a % de aumento salarial para este més de {func.Nome}: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("ATUALIZAÇÃO DOS DADOS DO FUNCIONÁRIO, APÓS AUMENTO: " + func);


            
        }

    }
}