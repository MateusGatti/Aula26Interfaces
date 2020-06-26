using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "Rocket League", 36.99f);
            Produto p2 = new Produto(2, "Life is Strange", 48.99f);
            Produto p3 = new Produto(3, "Stardew Valley", 19.99f);
            Produto p4 = new Produto(4, "Dreaming Sarah", 9.99f);

            carrinho.Criar(p1);
            carrinho.Criar(p2);
            carrinho.Criar(p3);
            carrinho.Criar(p4);

            carrinho.Remover(p1);

            Produto prodAlt = new Produto(3, "Left 4 Dead 2", 26.99f);
            carrinho.Alterar(3, prodAlt);

            carrinho.Ler();

            carrinho.MostrarTotal();
        }
    }
}
