using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
        
        }

        public Regiao(string nome,bool status)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Status = status;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }
}
