using EasyJob.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Application.Interfaces
{
    public interface IAnuncioServices
    {
        Task<IEnumerable<AnuncioDTO>> SelecionaAnuncios();
    }
}
