using System;
using System.Collections.Generic;

namespace Agenda
{
    class RepositorioPessoa
    {
        public static List<Pessoa> listaPessoas;      

        public RepositorioPessoa()
        {
            listaPessoas = new List<Pessoa>();
        }

        public string PersistirPessoa(string nome, string telefone, int idade)
        {
            try
            {
                Pessoa pessoa = new Pessoa { Nome = nome, Idade = idade, Telefone = telefone};
                listaPessoas.Add(pessoa);
                return "Pessoa cadastrada com Sucesso!";
            }
            catch (Exception)
            {
                return "Ocorreu um erro ao salvar uma nova pessoa";
                throw;
            }
        }

        public void ListarPessoa()
        {
            foreach (var lista in listaPessoas)
                Console.WriteLine(lista);
        }

        private void MontarPessoasNaTela()
        {
            int count = 0;
            Console.WriteLine("------------------------------------------");
            foreach (var lista in listaPessoas)
            {
                Console.WriteLine(count.ToString() + " - " + lista.Nome);
                count++;
            }
            Console.WriteLine("------------------------------------------");
        }


        public string ExcluirPessoa()
        {
            try
            {
                MontarPessoasNaTela();
                Console.Write("Informe o Código da Pessoa que deseja excluir: ");
                var index = int.Parse(Console.ReadLine());

                listaPessoas.RemoveAt(index);

                return "Pessoa Excluida com Sucesso!";
            }
            catch (Exception)
            {
                return "Falha na Exclusão.";
                throw;
            }
        }

        public string EditarPessoa()
        {
            try
            {
                MontarPessoasNaTela();
                Console.Write("Informe o Código da Pessoa que deseja Editar:");
                var index = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                string nova = "";
                Console.Write(string.Format("< Nome: {0} > Informa o Novo Nome: ", listaPessoas[index].Nome));
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].Nome = nova;
                    Console.WriteLine("");
                }

                Console.Write(string.Format("< Idade: {0} > Informa a Nova Idade: ", listaPessoas[index].Idade));
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].Idade = int.Parse(nova);
                    Console.WriteLine("");
                }

                Console.Write(string.Format("< Telefone: {0}> Informa o Novo Telefone: ", listaPessoas[index].Telefone));
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                    listaPessoas[index].Telefone = nova;
        
                return "Informações alteradas com sucesso!";
            }
            catch (Exception)
            {
                return "Não foi possível alterar as informações!";
                throw;
            }
        }
    }
}
