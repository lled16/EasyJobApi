using EasyJob.Application.DTOs;
using EasyJob.Application.Interfaces;
using EasyJob.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyJobApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnunciosController : ControllerBase
    {
        private readonly ILogger<AnunciosController> _logger;
        private readonly IAnuncioServices _anuncioServices;

        public AnunciosController(ILogger<AnunciosController> logger, IAnuncioServices anuncioServices)
        {
            _logger = logger;
            _anuncioServices = anuncioServices;
        } 

        [HttpGet(Name = "Seleciona todos os anuncios")]
        public async Task<ActionResult> Get()
        {
            IEnumerable<AnuncioDTO> anuncios = await _anuncioServices.SelecionaAnuncios();

            return Ok(anuncios);
        }
    }
}
