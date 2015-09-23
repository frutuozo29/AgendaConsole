using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {          
            var Aplicacao = new Aplicacao(new RepositorioPessoa());
            int opcao;
            do
            {
                opcao = Aplicacao.MenuPrincipal();
                Aplicacao.SelecionarMenuPelaOpcao(opcao);
            } while (opcao != 5);

            Console.Clear();
            Console.WriteLine("Fim da Aplicação.");
            Console.ReadKey();
        }
    }
}
