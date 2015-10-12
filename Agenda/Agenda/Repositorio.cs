using System;
using System.Collections.Generic;

namespace Agenda
{
    class Repositorio<T> : IRepositorio<T>
    {

        public static List<T> lista;

        public Repositorio()
        {
            lista = new List<T>();
        }

        public string Editar(T entidade)
        {
            throw new NotImplementedException();
        }

        public string Excluir(T entidade)
        {
            try
            {
                lista.Remove(entidade);
                return "Entidade removida com Sucesso!";
            }
            catch (Exception)
            {
                return "Falha na exclusão da Entidade!";
                throw;
            }
        }

        public string Excluir(int id)
        {
            try
            {
                lista.RemoveAt(id);
                return "Entidade removida com Sucesso!";
            }
            catch (Exception e)
            {
                return "Falha na exclusão da Entidade! " + e.Message;
                throw;
            }
        }

        public string Incluir(T entidade)
        {
            try
            {
                lista.Add(entidade);
                return "Entidade cadastrada com Sucesso!";
            }
            catch (Exception e)
            {
                return "Falha na inclusão da Entidade! " + e.Message;
                throw;
            }
        }

        public List<T> Listar()
        {
            return lista;
        }

    }
}
