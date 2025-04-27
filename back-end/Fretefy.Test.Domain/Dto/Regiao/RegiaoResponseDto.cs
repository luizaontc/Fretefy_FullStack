using Fretefy.Test.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Application.Dto
{
    public class RegiaoResponseDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public List<CidadeResponseDto> Cidades { get; set; }
    }
}
