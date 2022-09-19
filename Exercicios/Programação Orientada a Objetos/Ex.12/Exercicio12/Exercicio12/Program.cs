using Exercicio12;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            
            Console.Write("Informe a largura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Informe a altura do retangulo: ");
            r.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Área do retângulo: " + r);
        }
    }
}