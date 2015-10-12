using System;
using System.Collections.Generic;
using System.Linq;

namespace Agenda
{
    class RepositorioPessoa : Repositorio<Pessoa>
    {

        public void MontarNaTela()
        {
            int count = 0;
            Console.WriteLine("------------------------------------------");
            foreach (var lista in Listar())
            {
                Console.WriteLine(count.ToString() + " - " + lista.Nome);
                count++;
            }
            Console.WriteLine("------------------------------------------");
        }


        public void Listagem()
        {
            Listar().ForEach(lista => Console.WriteLine(lista));
        }

        public string Adicionar(string nome, string telefone, int idade)
        {
            Pessoa pessoa = new Pessoa { Nome = nome, Idade = idade, Telefone = telefone };
            return Incluir(pessoa);
        }

        public string Deletar(int index)
        {
            try
            {
                return Excluir(index);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string Editar()
        {
            try
            {
                MontarNaTela();
                Console.Write("Informe o Código da Pessoa que deseja Editar:");
                var index = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                string nova = "";
                Console.Write("< Nome: {0} > Informa o Novo Nome: ", Listar()[index].Nome);
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    Listar()[index].Nome = nova;
                    Console.WriteLine("");
                }

                Console.Write("< Idade: {0} > Informa a Nova Idade: ", Listar()[index].Idade);
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    Listar()[index].Idade = int.Parse(nova);
                    Console.WriteLine("");
                }

                Console.Write("< Telefone: {0}> Informa o Novo Telefone: ", Listar()[index].Telefone);
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                    Listar()[index].Telefone = nova;

                return "Informações alteradas com sucesso!";
            }
            catch (Exception)
            {
                return "Não foi possível alterar as informações!";
                throw;
            }
        }

        public Pessoa Pesquisar()
        {
            try
            {
                Console.Write("Informe o Nome da Pessoa que deseja pesquisar: ");
                var nome = Console.ReadLine();
                var queryPessoa = from pessoa in Listar()
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
                    Console.WriteLine("-----------------------------------------------------------");
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
