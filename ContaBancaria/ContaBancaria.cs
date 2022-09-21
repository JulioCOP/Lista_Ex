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
        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        // this para repassar o construtor de 2 argumentos.
        {
            // REALIZAR UM DEPOSITO DO VALOR INSERIDO PELO USUÁRIO

            Deposito(depositoInicial);

            // Assim o método de receber um deposito realizado pelo usuário
            // será feito pela operação da Função Deposito, assim, em caso de alteração
            //futura desta operação, é so realizar manuntenção do deposito
        }
        // Propriedades customizadas -  Funções para depósito e saldo

        // void = não vão retornar, apenas alterar o valor 
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }
        public void SaqueNacional(double quantia)
        {
            // taxa para operações bancárias nacionais
            SaldoDaConta = SaldoDaConta - quantia - (quantia * 0.38);
        }
        public void SaqueInternacional(double quantia)
        {
            //taxa para operações bancárias internações
            SaldoDaConta = SaldoDaConta - quantia - (quantia * 6.38);
        }
        //COMPILAR
        public override string ToString()
        {
            return "CONTA DO USUÁRIO: " + NumeroDaConta + " NOME DO TITULAR: " + NomeDoTitular + " SALDO DISPONÍVEL R$: " + SaldoDaConta.ToString("F2", CultureInfo.InvariantCulture);
        }


    }


}
