using System;
using System.Globalization;
// digitar um número decimal com "." no lugar da ","
    namespace Course
{
    class Program
    {
        static void Main(string[] args )
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            // ARMAZENAR DADOS EM UMA MESMA LINHA, AO DIGITAR NO TERMINAL
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            // Por padrão as entradas são retornadas em strings, sendo assim
            // ao armazenar alguma informação no vetor é necessário a conversão desses dados para variavel desejada
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);
            // variavel double com acrescismo da função para trocar a "," pelo "."



            Console.WriteLine("VOCÊ DIGITOU:");
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine($"{altura}");



        }
    }
}
