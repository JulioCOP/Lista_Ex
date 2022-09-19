using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - ((SalarioBruto * Imposto) / 100);
            
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (( SalarioBruto * porcentagem) / 100);
        }
        public override string ToString()
        {
            return Nome + " R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
