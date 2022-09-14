using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char geneto = 'M';

            double preco = 2100.0;
            double preco2 = 659.45;
            double medida = 31.6546739;


            Console.WriteLine($"{produto1}, cujo o preço é $ {preco:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}");
            Console.WriteLine($"Registro {idade} anos de idade, código {codigo} e gênero {geneto}");
            Console.WriteLine($"Medida total {medida:F1}");
        }
    }
}