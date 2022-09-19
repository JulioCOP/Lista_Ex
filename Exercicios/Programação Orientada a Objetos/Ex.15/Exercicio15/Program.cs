using Exercicio15;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dolar HOJE ? Em R$: ");
            ConversorDeMoeda.ValorEmReais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares serão comprados ? $ ");
            double qtdDolar= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double valorFinal = ConversorDeMoeda.Conversao(qtdDolar);

            Console.WriteLine($"Valor a pagar em R$: " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
