namespace Agenda
{
    interface IRepositorioPessoa
    {
        void Listar();

        string Adicionar(string nome, string telefone, int idade);

        string Excluir();

        string Editar();

        Pessoa Pesquisar();
    }
}
