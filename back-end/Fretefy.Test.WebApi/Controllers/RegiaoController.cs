using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/regiao")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult List([FromQuery] string nome, [FromQuery] string terms)
        {
            IEnumerable<Regiao> regioes;

            if (!string.IsNullOrEmpty(terms))
                regioes = _regiaoService.Query(terms);
            else if (!string.IsNullOrEmpty(nome))
                regioes = _regiaoService.ListByName(nome);
            else
                regioes = _regiaoService.List();

            return Ok(regioes);
        }

        [HttpPost("newRegiao")]
        public IActionResult Post([FromBody] RegiaoDTO regiao)
        {
            try
            {
                var newRegiao = _regiaoService.NewRegiao(regiao);

                return Ok(newRegiao);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateRegiao")]
        public IActionResult Put([FromBody] RegiaoDTO payload)
        {
            try
            {
                var regiao = _regiaoService.UpdateRegiao(payload);

                return Ok(regiao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("updateStatus")]
        public IActionResult Post([FromQuery] string nome)
        {
            try
            {
                Regiao regiao = _regiaoService.ChangeStatus(nome);

                return Ok(regiao);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
