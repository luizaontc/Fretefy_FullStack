using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace Fretefy.Test.Domain.Dto
{
    public class NovaRegiaoDto : IValidatableObject
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public List<Cidade> Cidades { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Cidades == null || Cidades.Count == 0)
            {
                yield return new ValidationResult("A lista de cidades deve conter pelo menos uma cidade.", new[] { nameof(Cidades) });
            }
        }
    }
}
