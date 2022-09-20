using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex16.ContaBancária
{
    class ContaBancaria
    {
        //1ºAtributos privados:
        public int NumeroDaConta { get; private set; }
        // Usuário pode acessar, mas não pode alterar o número da conta, uma vez que só existe uma conta pra aquele número
        public string NomeDoTitular { get; set; }
        // O usuário pode alterar seu nome ao longo da vida
        public double SaldoDaConta { get; private set; }
        // Saldo só pode ser alterado por meio de duas alternativas: SALDO OU SAQUE

        // 2º Costrutores:
        public ContaBancaria(int numero, string titular)
        {
            // Atribuições
            NumeroDaConta = numero;
            NomeDoTitular = titular;
        }
        // Construtor com 3 argumento
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        // this para repassar o construtor de 2 argumentos.
        {
            SaldoDaConta = saldo;
        }

        //COMPILAR
        public override string ToString()
        {
            return "CONTA DO USUÁRIO: " + NumeroDaConta + "NOME DO TITULAR: " + NomeDoTitular + "SALDO DISPONÍVEL R$: " + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }


    }


}
