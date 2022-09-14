// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.


using System;
using System.Globalization;

namespace Course{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            Console.WriteLine("INFORME A SENHA CORRETA");
            int senhaAcesso = int.Parse(Console.ReadLine());
            while (senhaAcesso != 2002)
            {
                Console.WriteLine("SENHA INCORRETA, INFORME A SENHA CORRETA");
                senhaAcesso = int.Parse(Console.ReadLine());
           
            }
            if (senha == 2002)
            {
                Console.WriteLine("SENHA CORRETA... ACESSANDO O SITEMA !");
                
            }
        }
    }
}