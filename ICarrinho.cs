namespace Aula26Interfaces
{
    public interface ICarrinho
    {
         
        void Ler();

        void Criar(Produto _produto);

        void Alterar(int _codigo, Produto _produto);

        void Remover(Produto _produto);
        
        void MostrarTotal();

    }
}