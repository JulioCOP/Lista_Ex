using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    internal class ConversorDeMoeda
    {
        public static double ValorEmReais;

        public static double Conversao(double valorConversao)
        {
            double convDireta = ValorEmReais * valorConversao;
            double convComIof = ((convDireta * 6) / 100) + convDireta;
            return convComIof;
        }
    }
}
