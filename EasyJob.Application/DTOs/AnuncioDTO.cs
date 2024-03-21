using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Application.DTOs
{
    public class AnuncioDTO
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage ="O título do anúncio não pode ultrapassar 25 Caracteres !")]
        public string Titulo { get; set; } = null!;

        [MaxLength(250, ErrorMessage = "A descrição não pode ultrapassar 250 caracteres !")]
        public string Descricao { get; set; } = null!;
        public decimal Valor { get; set; }
        public int AnuncianteId { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Status { get; set; }
    }
}
