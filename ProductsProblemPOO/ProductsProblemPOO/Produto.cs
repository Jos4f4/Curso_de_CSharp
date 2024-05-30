using System;
using System.Globalization;

namespace ProductsProblemPOO
{
    class Produto
    {

        /*
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {

        }

        public Produto(string Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }

        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            Quantidade = 0;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + " , $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
        */
        //GETTERS e SETTERS
        /*
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
           _nome = nome;
           _preco = preco;
           _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(_nome != null && _nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
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
                + " , $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
        */

        //PROPERTIES

        private string _nome;
        private double _preco; // public double Preco{ get; private set;}   DISPENSA O USO DE GETTERS E SETTERS
        private int _quantidade; // public double Quantidade { get; private set;}

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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
                + " , $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
