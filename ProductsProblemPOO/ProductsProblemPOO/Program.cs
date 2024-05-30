using System;
using System.Globalization;

namespace ProductsProblemPOO
{
    class PRogram
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            */

            /*
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            */
            /*
            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado(s) no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido(s) no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            */

            /*
            Produto p = new Produto("TV", 900.00, 10);
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            */

            Produto p = new Produto("TV", 900.00, 10);
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);

        }
    }
}