using System.Collections.Generic;

namespace Agenda
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }

        public List<Item> ListaItens { get; set; }
        
        public Pessoa()
        {
            ListaItens = new List<Item>();
        }

        public override string ToString()
        {
            foreach (Item item in ListaItens)
            {
                string itens = item.ToString() + "\n";
            }

            var retorno = "------------------------------------------\n" +
                           $"Nome    : {Nome}\n" +
                           $"Idade   : {Idade}\n" +
                           $"Telefone: {Telefone}\n" +
                            "------------------------------------------";
            return retorno;
        }

        public List<Item> GetListItens()
        {
            return ListaItens;
        }

    }
}
