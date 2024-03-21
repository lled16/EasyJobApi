using AutoMapper;
using EasyJob.Application.DTOs;
using EasyJob.Domain.Models;

namespace EasyJob.Application.Mappings
{
    public class DomainToDTOMapping: Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Anuncio, AnuncioDTO>().ReverseMap();
        }
    }
}
