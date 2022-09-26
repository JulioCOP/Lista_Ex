using Ex._20;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Usuário, quantos funcionarios vocÊ deseja registrar nesse sistema: ");
            int numeroDeFuncs = int.Parse(Console.ReadLine());
            List<Funcionario> listaDeFuncionarios= new List<Funcionario>();
            // Função lista para adicionar os dados do funcionário a classe do funcionário

            for (int i=1; i<=numeroDeFuncs; i++)
            {
                Console.WriteLine($"FUNCIONÁRIO Nº {i}");
                Console.Write("ID do funcionário: "); 
                int idFunc=int.Parse(Console.ReadLine());
                Console.Write("Nome do funcionário: ");
                string nomeFunc=Console.ReadLine();
                Console.Write("Salário do funcionário R$: ");
                double salarioFunc= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Adicionar os item da estrutura for dentro da lista
                listaDeFuncionarios.Add(new Funcionario(idFunc, nomeFunc, salarioFunc));
            }
            Console.Write("Informe a ID do funcionário que terá aumento salarial: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario func = listaDeFuncionarios.Find(x =>x.Id== idAumento);
            // A classe funcionario, possui uma variavél chamada 'func'. Esta variavel recebe
            // uma função, ao qual, é a lista de funcionários criada, esta por suas vez
            // // irá buscar o id informado no inicio do programa e selecionará o mesmo, para receber o 
            // respectivo aumento, de acordo com % a ser informada.

            if (func != null)
            {
                Console.Write("Informe o aumento que este funcionário terá: ");
                double aumentoSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalario(aumentoSalario);
            }
            else
            {
                Console.WriteLine("A ID informada não consta para nenhum funcionário informado pelo usuário");
            }
            Console.WriteLine();
            foreach(Funcionario funcionarioDaLista in listaDeFuncionarios)
            {
                Console.WriteLine("DADOS DOS FUNCIONÁRIOS: ");
                Console.WriteLine(funcionarioDaLista.ToString());

            }
        }
    }
}
