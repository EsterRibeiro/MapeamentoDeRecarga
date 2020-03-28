using System;
using System.Collections.Generic;
using System.Text;
using VerificacaoNoMapa.Domain.Entidades;

namespace VerificacaoNoMapa.Domain.Interfaces.Servicos
{
    public interface IBaseServico
    {
        void Adicionar(EstacaoRecarga obj);
        EstacaoRecarga RecuperarPorId(Guid Id);
        void Atualiar(EstacaoRecarga obj);
        void Excluir(EstacaoRecarga obj);
        IList<EstacaoRecarga> Listar();
    }
}
