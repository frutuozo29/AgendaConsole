using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string telefone;

        public string PersistirPessoa(List<Pessoa> listaPessoas, string nome, string telefone, int idade)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = nome;
                pessoa.telefone = telefone;
                pessoa.idade = idade;
                listaPessoas.Add(pessoa);
                return "Pessoa cadastrada com Sucesso!";
            }
            catch (Exception)
            {
                return "Ocorreu um erro ao salvar uma nova pessoa";
                throw;
            }
        }

        public void ListarPessoa(List<Pessoa> listaPessoas)
        {
            foreach (var lista in listaPessoas)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Nome    : " + lista.nome);
                Console.WriteLine("Idade   : " + lista.idade.ToString());
                Console.WriteLine("Telefone: " + lista.telefone);
                Console.WriteLine("------------------------------------------");
            }
        }

        private void MontarPessoasNaTela(List<Pessoa> listaPessoas)
        {
            int count = 0;
            Console.WriteLine("------------------------------------------");
            foreach (var lista in listaPessoas)
            {
                Console.WriteLine(count.ToString() + " - " + lista.nome);
                count++;
            }
            Console.WriteLine("------------------------------------------");
        }


        public string ExcluirPessoa(List<Pessoa> listaPessoas)
        {
            try
            {
                MontarPessoasNaTela(listaPessoas);
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

        public string EditarPessoa(List<Pessoa> listaPessoas)
        {
            try
            {
                MontarPessoasNaTela(listaPessoas);
                Console.Write("Informe o Código da Pessoa que deseja Editar:");
                var index = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                string nova = "";
                Console.Write("< Nome: " + listaPessoas[index].nome + ">" + " Informa o Novo Nome: ");
                nova = Console.ReadLine();
                if (! String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].nome = nova;
                    Console.WriteLine("");
                }
                
                Console.Write("< Idade: " + listaPessoas[index].idade + ">" + " Informa a Nova Idade: ");
                nova = "";
                nova = Console.ReadLine();
                if (! String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].idade = int.Parse(nova);
                    Console.WriteLine("");
                }
               
                Console.Write("< Telefone: " + listaPessoas[index].telefone + ">" + " Informa o Novo Telefone: ");
                nova = "";
                nova = Console.ReadLine();
                if (!String.IsNullOrEmpty(nova))
                {
                    listaPessoas[index].telefone = nova;
                }

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
