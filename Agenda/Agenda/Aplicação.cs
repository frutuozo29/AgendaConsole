using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Aplicacao
    {
        public static List<Pessoa> listaPessoas;
        Pessoa pessoa;

        public Aplicacao()
        {
            pessoa = new Pessoa();
        }


        public void LimparConsole()
        {
            Console.Clear();
        }


        public void ValidarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    IncluirPessoa();
                    break;
                case 2:
                    ListarPessoas();
                    break;
                case 3:
                    ExcluirPessoa();
                    break;
                case 4:
                    EditarPessoa();
                    break;
                default:
                    break;
            }
        }


        public int MenuPrincipal()
        {
            var opcoes = new[] { 1, 2, 3, 4, 5 };
            int opcao;
            do
            {
                LimparConsole();
                Console.WriteLine(".: Sistema de Agenda CSharp :.");
                Console.WriteLine("");
                Console.WriteLine("1- Cadastrar Pessoa");
                Console.WriteLine("2- Listar Pessoas");
                Console.WriteLine("3- Excluir Pessoa");
                Console.WriteLine("4- Editar Pessoas");
                Console.WriteLine("5- Sair");
                Console.Write("Informe uma opção: ");
                opcao = int.Parse(Console.ReadLine());
            } while (!opcoes.Contains(opcao));
            return opcao;
        }


        void IncluirPessoa()
        {
            LimparConsole();
            Console.WriteLine(".: Cadastro de Pessoas:. ");
            Console.Write("Digite um Nome:");
            var nome = Console.ReadLine();
            Console.Write("Digite a Idade:");
            var idade = int.Parse(Console.ReadLine());
            Console.Write("Digite o Telefone:");
            var telefone = Console.ReadLine();

            var retorno = pessoa.PersistirPessoa(GetListaPessoas(), nome, telefone, idade);
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        void ListarPessoas()
        {
            LimparConsole();
            Console.WriteLine(" .: Exibição da Lista de Pessoas :. ");
            pessoa.ListarPessoa(GetListaPessoas());
            Console.ReadKey();
        }

        void ExcluirPessoa()
        {
            LimparConsole();
            Console.WriteLine(" .: Exclusão de Pessoa :. ");
            var retorno = pessoa.ExcluirPessoa(GetListaPessoas());
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        void EditarPessoa()
        {
            LimparConsole();
            Console.WriteLine(" .: Editando Pessoas :. ");
            var retorno = pessoa.EditarPessoa(GetListaPessoas());
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        public List<Pessoa> GetListaPessoas()
        {
            if (listaPessoas == null)
            {
                listaPessoas = new List<Pessoa>();
                return listaPessoas;
            }
            else
            {
                return listaPessoas;
            }
        }

    }
}
