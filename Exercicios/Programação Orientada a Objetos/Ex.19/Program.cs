using Ex._19;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int numeroQuartos= int.Parse(Console.ReadLine());

            // Criar vetor do tipo classe com atributos privados
            Estudante[] vect = new Estudante[10];

            // Estrutura repetida FOR -> leitura nome, email e quarto desejado -  instanciação e inserir nas posições do vetor

            for (int i = 1; i <= numeroQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"ALUGUEL Nº {i}");
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write($"EMAIL DE {nome}: ");
                string email = Console.ReadLine();
                Console.Write($"Nº DO QUARTO P/ ALUGAR: ");
                int quarto = int.Parse(Console.ReadLine());
                // Instanciar e adicionar variaveis as pósições dos vetores

                vect[quarto]= new Estudante(nome,email, quarto);
            }
            // Posições criadas no vetor são nulas, é necessário instacia-las para conseguir armazenar valores;

            // Necessário uso do for, para atribuir um valor para variavel que inidicará a posição correspondente
            for (int i = 0; i < 10; i++){
                if (vect[i] != null)
                // Se o vetor na posição i - for diferente de um valor nulo, é atribuido para a posição determinada o valor correspondente ao dados do quarto
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }    
            }
        }
    }
}