using Ex16.ContaBancária;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Informe o Nº do TITULAR da conta: ");
            int numero = int.Parse(Console.ReadLine());

            // Loop infinito caso o Nº DA CONTA > 4 digitos
            while (numero.ToString().Length > 4)
            {
                Console.Write("DIITE OS 4 ULTIMOS NÚMEROS DA CONTA: ");
                numero = int.Parse(Console.ReadLine());
                if (numero.ToString().Length <= 4)
                {
                    break;
                }
            }
            Console.Write("Informe o primeiro e o ultimo nome do TITULAR da conta: ");
            string titular = Console.ReadLine();
            Console.Write($"{titular}, você irá fazer algum depósito incial ? [S] / [N] ");
            char resp = char.Parse(Console.ReadLine());
            while (resp != 's' && resp != 'S' && resp != 'n' && resp != 'N')
            // Looping infintio em caso de o usuário informar a resposta errada
            {
                Console.Write($"{titular}, você irá fazer algum depósito incial ? [S] / [N] ");
                resp = char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S' || resp == 'n' || resp == 'N')
                {
                    break;
                }
            }
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Digite o valor R$: ");
                // Uso de uma variável, temporária
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, deposito);
                // Construtor para receber os atributos da conta

            }
            else if (resp == 'n' || resp == 'N')
            {
                Console.WriteLine($"{titular} optou por não realizar nenhum deposito");
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine(conta);
        }
    }
}
   
