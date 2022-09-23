using Ex18.VETORES;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar classe
            int n = int.Parse(Console.ReadLine());
            // Criar o vetor para ser armazenado dados da classe

            Produt[] vect = new Produt[n];
            // Vetor do tipo classe criado
            // Ao adicionar um objeto no vetor é necessário instaciar os objetos e depois inseri-los no vetor

            for (int i=0;i<n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Instaciar o objeto
                vect[i]= new Produt { Nome=nome, Preco=preco};  
                
                // A partir do for, é criado uma estrutura ao qual o vetor criado de acordo com valor informado, que antes tinha suas posições nulas
                // é instanciado e o valores adicionados para nome e preço são inserido nas posições dos vetores
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma+= vect[i].Preco;
                // for pecorre as posições do produtoe acessa as cassas responsáveis pelo preço, que foram adionado no comando anteriormente informado 
            }
            double media = soma / n;
            Console.WriteLine($"Preço médio igual a R$: {media:F2}", CultureInfo.InvariantCulture);
        }
    }
}