using EasyJob.Domain.Interfaces;
using EasyJob.Domain.Models;
using EasyJob.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Infra.Data.Repositories
{
    public class AnunciosRepository : IAnunciosRepository
    {
        private readonly ApplicationDbContext _context;

        public AnunciosRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Anuncio>> SelectAnuncios()
        {
            return await _context.Anuncio.ToListAsync();

        }
    }
}
