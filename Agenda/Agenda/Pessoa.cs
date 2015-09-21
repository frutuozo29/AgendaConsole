using System.Collections.Generic;

namespace Agenda
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }

        public static List<Item> listaItens;

        public Pessoa()
        {
            listaItens = new List<Item>();
        }

        public override string ToString()
        {
            foreach (Item item in listaItens)
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
            return listaItens;
        }

    }
}
