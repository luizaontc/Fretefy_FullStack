using Fretefy.Test.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
                
        }

        public Regiao(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Status = true;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Status  { get; set; }
        public List<Cidade> cidades { get; set; }

    }
}
