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
            else
            {
                Console.WriteLine($"{titular} optou por não realizar nenhum deposito");
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Deseja depositar algum valor ? [S] / [N] ");
            char depos = char.Parse(Console.ReadLine());
            if (depos=='s' || depos == 'S')
            {
                Console.Write("Qual o valor deseja depositar R$: ");
                double qtdDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                // Chamar a função deposito, para adionar um valor a conta
                conta.Deposito(qtdDinheiro);
            }
            else
            {
                Console.WriteLine("Não haverá deposito, aguarde o processamento de seus dados bancários...");
            }
            Console.WriteLine($"Dados da conta de {titular} ATUALIZADOS: ");
            Console.WriteLine(conta);

            // caso usuário deseje realizar um saque
            Console.WriteLine();
            Console.WriteLine("Deseja realizar algum saque ? [S] / [N] ");
            Console.WriteLine("Será cobrado uma taxa de 0.38%");
            depos = char.Parse(Console.ReadLine());
            if (depos == 's' || depos == 'S')
            {
                Console.Write("Qual o valor do saque R$: ");
                double qtdDinheiro = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                // Chamar a função deposito, para adionar um valor a conta
                conta.SaqueNacional(qtdDinheiro);
            }
            else
            {
                Console.WriteLine("Não haverá saque, aguarde o processamento de seus dados bancários...");
            }
            Console.WriteLine($"Dados da conta de {titular} ATUALIZADOS: ");
            Console.WriteLine(conta);
        }
    }
}
   
