using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
   
        public Produto()
        {
            _quantidade = 0;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome (string nome)
        //void pois nã irá haver retorno como saída, apenas alteração do atributo nome
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;

            }
        }

        //evitar alteração da quantidade e do preço

        public double GetPreco(){
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
