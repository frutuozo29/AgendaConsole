using System;

namespace Agenda
{
    class RepositorioItem : IRepositorioItem
    {
        public string Adicionar(Pessoa pessoa, string descricao, double valor)
        {
            try
            {
                var item = new Item() { Descricao = descricao, Valor = valor };
                pessoa.GetListItens().Add(item);
                return "Item cadastrado com Sucesso!";
            }
            catch (Exception)
            {
                return "Falha na Inclusão do Item.";
                throw;
            }
        }

        public string Editar()
        {
            throw new NotImplementedException();
        }

        public string Excluir()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public Item Pesquisar()
        {
            throw new NotImplementedException();
        }
    }
}
