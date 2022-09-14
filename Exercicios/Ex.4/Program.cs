using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Nº correspondente ao funcionário:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("A hora total trabalhada por este funciónario no mês:");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe quanto é a hora deste funcionário R$: ");
            double custo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = hora * custo;

            Console.WriteLine($"O funcionário de codigo {numero} trabalhou {hora} horas no mês e seu salário foi de R$ {salario:F2}");
                
        }
    }
}