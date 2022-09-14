//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar.


using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME O CODIGO DO PRODUTO DESEJADO ENTRE O INTERVALOR 1 A 5");
            // CACHORRO QUENTE => R$ 4.00 - CDG = 1
            // X-SALADA => R$ 4.50 - CDG = 2
            // X-BACON => R$ 4.00 - CDG = 3
            // TORRADA SIMPLES => R$ 4.00 - CDG = 4
            // REFRIGERANTE => R$ 4.00 - CDG = 5


            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int qtd = int.Parse(vet[1]);
            
            double valorPagar = 0.0;
            if (codigo == 1)
            {
                valorPagar = qtd * 4.00;
                Console.WriteLine($"TOTAL A PAGAR R$ {valorPagar:F2}", CultureInfo.InvariantCulture);
            }
            else if (codigo == 2)
            {
                valorPagar = qtd * 4.50;
                Console.WriteLine($"TOTAL A PAGAR R$ {valorPagar:F2}", CultureInfo.InvariantCulture);
            }
            else if (codigo == 3)
            {
                valorPagar = qtd * 5.00;
                Console.WriteLine($"TOTAL A PAGAR R$ {valorPagar:F2}", CultureInfo.InvariantCulture);
            }
            else if (codigo == 4)
            {
                valorPagar = qtd * 2.00;
                Console.WriteLine($"TOTAL A PAGAR R$ {valorPagar:F2}", CultureInfo.InvariantCulture);
            }
            else if (codigo == 5) 
            {
                valorPagar = qtd * 1.50;
                Console.WriteLine($"TOTAL A PAGAR R$ {valorPagar:F2}", CultureInfo.InvariantCulture);

            }
            else
            {
                Console.WriteLine("O USUÁRIO NÃO DIGITOU NENHUM CÓDIGO");
            }


        }
    }
}
