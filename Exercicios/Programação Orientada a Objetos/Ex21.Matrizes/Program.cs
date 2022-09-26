using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            // Para usuário digitar n linhas e n colunas:

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                // lê a linha inteira, recorta os pedaços em branco e coloca dentro do vetor valores
                for (int j =0; j < n; j++)
                // pecorre os vetor valores, armazenando os valores de acordo com a posição
                {
                    mat[i, j] = int.Parse(valores[j]);   
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i]);
            }
            // Percorrer a matriz inteira:
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; i++)
                {
                    // quantidade de negativos
                    c++;
                }
            }
            Console.WriteLine($"Numeros negativos: {c}");
        }
    }
}
