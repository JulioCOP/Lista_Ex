using System;
using System.Globalization;
namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE O NOME DO USUÁRIO: ");
            string nome = Console.ReadLine();

            Console.WriteLine("QUANTOS CARTOS TEM NA CASA");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, quanto custou a compra do seu ultimo produto ? ");
            double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("INFORME SEU NOME, IDADE E ALTURA NA MESMA LINHA");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture); 


            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine($"{compra:F2}");
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine($"{altura:F2}");




        }
    }
}

