using System;
using System.Linq;

namespace Agenda
{
    class Aplicacao
    {
        IRepositorioPessoa _repositorioPessoa;
        IRepositorioItem _repositorioItem;

        public Aplicacao(IRepositorioPessoa repositorioPessoa, IRepositorioItem repositorioItem)
        {
            _repositorioPessoa = repositorioPessoa;
            _repositorioItem = repositorioItem;
        }

        public void LimparConsole()
        {
            Console.Clear();
        }

        public void SelecionarMenuPelaOpcao(int opcao)
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
                case 11:
                    CadastrarItensPessoa();
                    break;
                case 22:
                    ListarPessoasItens();
                    break;
                default:
                    break;
            }
        }


        public int MenuPrincipal()
        {
            try
            {
                var opcoes = new[] { 1, 2, 3, 4, 5, 11, 22, 33, 44 };
                int opcao;
                do
                {
                    LimparConsole();
                    Console.WriteLine(".: Sistema de Agenda CSharp :.");
                    Console.WriteLine("");
                    Console.WriteLine("1- Cadastrar Pessoa");
                    Console.WriteLine("   11 Cadastrar Itens da Pessoa");
                    Console.WriteLine("");
                    Console.WriteLine("2- Listar Pessoas");
                    Console.WriteLine("   22 Listar Pessoas e seus Itens");
                    Console.WriteLine("");
                    Console.WriteLine("3- Excluir Pessoa");
                    Console.WriteLine("   33 Excluir Itens da Pessoa");
                    Console.WriteLine("");
                    Console.WriteLine("4- Editar Pessoas");
                    Console.WriteLine("   44 Editar Itens da Pessoas");
                    Console.WriteLine("");
                    Console.WriteLine("5- Sair");
                    Console.Write("Informe uma opção: ");
                    opcao = int.Parse(Console.ReadLine());
                } while (!opcoes.Contains(opcao));
                return opcao;
            }
            catch (Exception)
            {
                return 5;
                throw;
            }
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

            var retorno = _repositorioPessoa.Adicionar(nome, telefone, idade);
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        void ListarPessoas()
        {
            LimparConsole();
            Console.WriteLine(" .: Exibição da Lista de Pessoas :. ");
            _repositorioPessoa.Listar();
            Console.ReadKey();
        }

        void ExcluirPessoa()
        {
            LimparConsole();
            Console.WriteLine(" .: Exclusão de Pessoa :. ");
            var retorno = _repositorioPessoa.Excluir();
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        void EditarPessoa()
        {
            LimparConsole();
            Console.WriteLine(" .: Editando Pessoas :. ");
            var retorno = _repositorioPessoa.Editar();
            Console.WriteLine(retorno);
            Console.ReadKey();
        }

        void CadastrarItensPessoa()
        {
            LimparConsole();
            Console.WriteLine(" .: Cadastro de Itens da Pessoa :.");
            var pessoa = _repositorioPessoa.Pesquisar();
            if (pessoa != null)
            {
                Console.Write("Informe uma Descrição: ");
                var descricao = Console.ReadLine();
                Console.Write("Informe o Valor do Item: ");
                var valor = double.Parse(Console.ReadLine());

                var retorno = _repositorioItem.Adicionar(pessoa, descricao, valor);
                Console.WriteLine(retorno);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nenhuma Pessoa foi encontrada, ou a opção selecionada foi inválida.");
                Console.ReadKey();
            }            
        }
        
        void ListarPessoasItens()
        {
            LimparConsole();
            Console.WriteLine(" .: Exibição da Lista de Pessoas e seus Itens :. ");
           // _repositorioPessoa.ListarPessoasItens();
            Console.ReadKey();
        }        
    }
}
