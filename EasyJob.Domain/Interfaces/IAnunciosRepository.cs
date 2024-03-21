using EasyJob.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Domain.Interfaces
{
    public interface IAnunciosRepository
    {
        Task<IEnumerable<Anuncio>> SelectAnuncios();
    }
}
