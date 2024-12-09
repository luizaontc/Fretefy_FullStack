using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Fretefy.Test.Domain.Dto
{
    public class RegiaoDTO
    {
        public RegiaoDTO() { }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        public List<CidadeDTO> cidades { get; set; }
    }
}
