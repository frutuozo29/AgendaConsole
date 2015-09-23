namespace Agenda
{
    interface IRepositorioItem
    {
        void Listar();

        string Adicionar(Pessoa pessoa, string descricao, double valor);

        string Excluir();

        string Editar();

        Item Pesquisar();
    }
}
