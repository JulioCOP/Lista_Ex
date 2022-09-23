using Ex._19;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Mian(string[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int numeroQuartos= int.Parse(Console.ReadLine());

            // Criar vetor do tipo classe cin atributos privados
            Estudante[] vect = new Estudante[numeroQuartos];

            // Estrutura repetitia FOR -> leitura nome, email e quarto desejado -  instanciação e inserir nas posições do vetor

            for (int i = 0; i < numeroQuartos; i++)
            {
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write($"EMAIL DE {nome}: ");
                string email = Console.ReadLine();
                Console.Write($"Nº DO QUARTO P/ ALUGAR: ");
                int quarto = int.Parse(Console.ReadLine());
                // Instaciar e adicionar variaveis as pósições dos vetores

                vect[i]= new Estudante(nome,email,quarto);
            }
            Console.WriteLine();
            
        }
    }
}