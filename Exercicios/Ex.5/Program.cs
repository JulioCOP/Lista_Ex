//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
//mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.

using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split(' ');
            double a= Double.Parse(valor[0],CultureInfo.InvariantCulture);
            double b= Double.Parse(valor[1], CultureInfo.InvariantCulture);
            double c= Double.Parse(valor[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (double)(a * c) / 2;
            Console.WriteLine($"A área do triangulo = {areaTriangulo:F2}");

            double areaCirculo = (double)3.14159 * Math.Pow(c, 2);
            Console.WriteLine($"A área da circunferência = {areaCirculo:F3}");
            
            double areaTrapezio = (double)(((a+b)*c) / 2);
            Console.WriteLine($"A área do trapezio = {areaTrapezio:F4}");

            double areaQuadrado = (double)Math.Pow(b, 2);
            Console.WriteLine($"A area do quadrado {areaQuadrado}");

            double areaRetangulo = (double)a * b;
            Console.WriteLine($"A área do retangulo {areaRetangulo}");





            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            //Console.WriteLine(valor3);


        }
    }
}
