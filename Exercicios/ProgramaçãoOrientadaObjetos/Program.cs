using Ex._11;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa n, id, nomeMaisVelho,maisVelho;
            n = new Pessoa();
            id=new Pessoa();
            nomeMaisVelho= new Pessoa();
            maisVelho = new Pessoa();
            for (int i=0; i< 5; i++)
            {
                Console.WriteLine($"Dados da {i+1}º pessoa:");
                Console.Write("Nome: ");
                n.nome = Console.ReadLine();
                Console.Write("Idade: ");
                id.idade = int.Parse(Console.ReadLine());
                
                if (maisVelho.idadeVelha<id.idade)
                {
                    maisVelho.idadeVelha=id.idade;
                    nomeMaisVelho.pessoaMaisVelha= n.nome;
                }
            }
            Console.Write($"A pessoa mais velha é:{nomeMaisVelho.pessoaMaisVelha} e ela tem {maisVelho.idadeVelha} anos");
        }
    }
}