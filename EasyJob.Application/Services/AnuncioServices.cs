using AutoMapper;
using EasyJob.Application.DTOs;
using EasyJob.Application.Interfaces;
using EasyJob.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyJob.Application.Services
{
    public class AnuncioServices : IAnuncioServices
    {
        private readonly IAnunciosRepository _anunciosRepository;
        private readonly IMapper _mapper;

        public AnuncioServices(IAnunciosRepository anunciosRepository, IMapper mapper)
        {
            _anunciosRepository = anunciosRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<AnuncioDTO>> SelecionaAnuncios()
        {
            var anuncios = await _anunciosRepository.SelectAnuncios();

            return _mapper.Map<IEnumerable<AnuncioDTO>>(anuncios);
        }
    }
}
