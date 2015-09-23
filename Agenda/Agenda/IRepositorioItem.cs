namespace Agenda
{
    interface IRepositorioItem
    {
        void Listar();

        string Adicionar(string descricao, double valor);

        string Excluir();

        string Editar();

        Item Pesquisar();
    }
}
