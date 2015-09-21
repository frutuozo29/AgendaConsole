using System;

namespace Agenda
{
    class RepositorioItem
    {

        public string CadastrarItens(Pessoa pessoa)
        {
            try
            {
                Console.Write("Informe uma Descrição: ");
                var descricao = Console.ReadLine();
                Console.Write("Informe o Valor do Item: ");
                var valor = double.Parse(Console.ReadLine());

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

    }
}
