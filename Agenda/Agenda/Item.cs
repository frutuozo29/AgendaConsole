namespace Agenda
{
    class Item
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            var retorno = $"     -Descricao: {Descricao} -Valor: {Valor.ToString()}";                          
            return retorno;
        }


    }
}
