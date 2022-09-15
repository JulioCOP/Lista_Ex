//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
//exemplo.

using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POR FAVOR, INFORME A OPÇÃO DESEJADA");
            Console.WriteLine("[1] ALCOOL [2] GASOLINA [3] DIESEL [4] FIM");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int escolhaCliente = int.Parse(Console.ReadLine());

            while (escolhaCliente != 4)
            {
            
                if (escolhaCliente > 4 || escolhaCliente <= 0)
                {
                    Console.WriteLine("OPÇÃO INCORRETA, POR FAVOR DIGITE UMA OPÇÃO DE ACORDO COM MENU");
                }
            
                if (escolhaCliente == 1)
                {
                    alcool += 1;
                }
                else if (escolhaCliente == 2)
                {
                    gasolina += 1;
                }
                else if (escolhaCliente ==3)
                {
                    diesel += 1;
                }
                escolhaCliente = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("DADOS DE ABASTECIMETNO NESSE POSTO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
            Console.WriteLine("MUITO OBRIGADO");
        }
    }
}