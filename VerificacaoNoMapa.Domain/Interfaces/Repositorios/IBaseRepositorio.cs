using System;
using System.Collections.Generic;
using System.Text;

namespace VerificacaoNoMapa.Domain.Interfaces.Repositorios
{
    public interface IBaseRepositorio<T> where T : class
    {
        void Adicionar(T obj);
        T RecuperarPorId(Guid Id);
        void Atualiar(T obj);
        void Excluir(T obj);
        IList<T> Listar();

    }
}
