using System.Collections.Generic;

namespace Agenda
{
    interface IRepositorio<T>
    {
        List<T> Listar();
        string Incluir(T entidade);
        string Excluir(int id);
        string Excluir(T entidade);
        string Editar(T entidade);
    }
}
