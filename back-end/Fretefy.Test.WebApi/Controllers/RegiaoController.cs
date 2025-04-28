using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpPost]
        [Route("/novaRegiao")]
        public async Task<IActionResult> Post([FromBody] NovaRegiaoDto dto)
        {
            try
            {
                var regiao = await _regiaoService.NovaRegiao(dto);

                return Ok(regiao);
            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao criar região: {ex.Message}");
            }
        }

        [HttpPut]
        [Route("/editarRegiao")]
        public async Task<IActionResult> Put([FromBody] EditarRegiaoDto dto)
        {
            try
            {
                var regiao = await _regiaoService.EditarRegiaoDto(dto);
                return Ok(regiao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao editar região: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/buscarRegiaoById")]
        public async Task<IActionResult> GetById([FromQuery] Guid IdRegiao)
        {
            try
            {
                var regiao = await _regiaoService.GetRegiaoById(IdRegiao);
                return Ok(regiao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar região pelo ID: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("/buscarRegiao")]
        public async Task<IActionResult> Get(int page, int pageSize)
        {
            try
            {
                var regiao = await _regiaoService.ListRegioes(page, pageSize);
                return Ok(regiao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar região pelo ID: {ex.Message}");
            }
        }
    }
}
