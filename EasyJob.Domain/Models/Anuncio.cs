using System;
using System.Collections.Generic;

namespace EasyJob.Domain.Models
{
    public partial class Anuncio
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Valor { get; set; }
        public int AnuncianteId { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Status { get; set; }
    }
}
