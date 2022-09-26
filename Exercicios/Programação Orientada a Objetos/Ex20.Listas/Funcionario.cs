using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._20
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoSalario(double aumento)
        {
            Salario += (Salario * (aumento / 100));
        }
        public override string ToString()
        {
            return Id + "-> " + Nome + "-> " +"Salário R$: " + Salario;
        }
    }
}
