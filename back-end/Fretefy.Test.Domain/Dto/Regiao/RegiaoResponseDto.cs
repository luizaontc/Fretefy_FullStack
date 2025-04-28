using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Application.Dto
{
    public class RegiaoResponseDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}
