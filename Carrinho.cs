using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto _produto)
        {
            carrinho.Find(z => z.Codigo == _codigo).Nome = _produto.Nome;
            carrinho.Find(z => z.Codigo == _codigo).Preco = _produto.Preco;
        }

        public void Criar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto x in carrinho){
                System.Console.WriteLine($"R$ {x.Preco} - {x.Nome} ");
            }
        }

        public float ValorTotal { get; set; }

        public void MostrarTotal()
        {
            foreach(Produto item in carrinho){

                ValorTotal += item.Preco;

            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine($"Valor total da compra: R$ {ValorTotal}");
            Console.ResetColor();
        }

        public void Remover(Produto _produto)
        {
            
            carrinho.Remove(_produto);
        }
    }
}