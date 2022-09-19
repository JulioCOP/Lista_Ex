using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Aluno
    {
        public double Notas;
       

        public double SomaTotalNotas()
        {
            double totalNotas = Notas + Notas + Notas;
            return totalNotas;
        }
        public bool Aprovado()
        {
            if (SomaTotalNotas() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double ValorRestante()
        {
            return 60.0 - SomaTotalNotas();
        }
       
        public override string ToString()
        {
            return SomaTotalNotas().ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
       
}
