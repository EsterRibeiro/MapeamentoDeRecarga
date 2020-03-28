using System;
using System.Collections.Generic;
using System.Text;
using VerificacaoNoMapa.Domain.NewFolder;

namespace VerificacaoNoMapa.Domain.Entidades
{
    public class EstacaoRecarga
    {
        public EstacaoRecarga(Guid id, string nome, TipoEstacao tipoEstacao, double latitude, double longitude)
        {
            Id = id;
            Nome = nome;
            TipoEstacao = tipoEstacao;
            Latitude = latitude;
            Longitude = longitude;
        }

        public EstacaoRecarga() { }

        private Guid Id { get; set; }
        private string Nome { get; set; }
        private TipoEstacao TipoEstacao { get; set; }
        private double Latitude { get; set; }
        private double Longitude { get; set; }
    }
}
