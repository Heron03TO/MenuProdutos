using System;
using SistemaEstoque;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estoque Couro Brindes");

            Item p = new Item();
            p.Nome = "Carteira simples em couro";
            p.Referencia = 051;
            p.preco = 45.00;
            p.ExibirDadosItem();

            Console.WriteLine();

            Item p1 = new Item();
            p1.Nome = "Mochila em couro com porta notebook";
            p1.Referencia = 057;
            p1.preco = 350.00;
            p1.ExibirDadosItem();

            Console.WriteLine();

            Item p2 = new Item();
            p2.Nome = "Bloco de anotações em couro";
            p2.Referencia = 027;
            p2.preco = 80.00;
            p2.ExibirDadosItem();

            Console.WriteLine();

            Console.WriteLine("Pressione uma tecla para fechar");

            Console.ReadKey();
            
            





        }
    }
}