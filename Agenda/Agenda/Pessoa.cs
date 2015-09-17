namespace Agenda
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            var retorno =  $"------------------------------------------\n"+
                           $"Nome    : {Nome}\n"+
                           $"Idade   : {Idade}\n"+
                           $"Telefone: {Telefone}\n"+
                           $"------------------------------------------";
            return retorno;
        }

    }
}
