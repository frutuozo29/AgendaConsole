using System;
using System.Collections.Generic;
using System.Linq;

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
                Pessoa pessoa = new Pessoa { Nome = nome, Idade = idade, Telefone = telefone };
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
            listaPessoas.ForEach(lista => Console.WriteLine(lista));
        }

        public void ListarPessoasItens()
        {
            MontarPessoasNaTela(true);
        }

        private void MontarPessoasNaTela(bool mostrarItens = false)
        {
            int count = 0;
            Console.WriteLine("------------------------------------------");
            foreach (var lista in listaPessoas)
            {
                Console.WriteLine(count.ToString() + " - " + lista.Nome);
                if (mostrarItens)
                {
                    var listaItens = lista.GetListItens();
                    listaItens.ForEach(item => Console.WriteLine(item));
                }
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
                Console.Write("< Nome: {0} > Informa o Novo Nome: ", listaPessoas[index].Nome);
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].Nome = nova;
                    Console.WriteLine("");
                }

                Console.Write("< Idade: {0} > Informa a Nova Idade: ", listaPessoas[index].Idade);
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].Idade = int.Parse(nova);
                    Console.WriteLine("");
                }

                Console.Write("< Telefone: {0}> Informa o Novo Telefone: ", listaPessoas[index].Telefone);
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

        public Pessoa SelecionarPessoa()
        {
            try
            {
                Console.Write("Informe o Nome da Pessoa que deseja pesquisar: ");
                var nome = Console.ReadLine();
                var queryPessoa = from pessoa in listaPessoas
                                  where pessoa.Nome.Contains(nome)
                                  select pessoa;
                
                if (queryPessoa.Count() != 0)
                {
                    int x = 0;
                    Console.WriteLine($"Foram encontrada(s) {queryPessoa.Count().ToString()} Pessoa(s) com esse Nome.");
                    Console.WriteLine("-----------------------------------------------------------");
                    foreach (var pessoa in queryPessoa)
                    {
                        Console.WriteLine(x.ToString() + " - " + pessoa.Nome);
                        x++;
                    }
                    Console.Write("Selecione a que deseja incluir o Item:");
                    var index = int.Parse(Console.ReadLine());
                    return queryPessoa.ElementAt(index);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
