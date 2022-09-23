// Programa solicita quantas idades serão informadas pelo usuário e ao fim 
// mostra o resultado da soma essas idades

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            // CRIAR UM VETOR -  para armazenar as alturas informadas de acordo com a quantidade de pessoas.
            double[] vect= new double[n];

            // Estrutura FOR para pecorrer as posições do vetor e ir armazenando dados.

            for (int i = 0; i < n; i++)
            {
                vect[i]= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }
            double media = soma / n;
            Console.WriteLine($"MEDIA DE ALTURA {media:F2}",CultureInfo.InvariantCulture);
        }
    }
}