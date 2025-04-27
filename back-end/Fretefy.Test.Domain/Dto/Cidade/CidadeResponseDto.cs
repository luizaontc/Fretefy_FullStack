using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Dto
{
    public class CidadeResponseDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public List<RegiaoCidade> regiaoCidades { get; set; }
    }
}
