using System;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : IEntity
    {
        public Cidade()
        {
        
        }

        public Cidade(string nome, string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
        }
        public Cidade(string nome, int regiaoId,string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            RegiaoId = RegiaoId;
            UF = uf;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int RegiaoId { get; set; }
        public string UF { get; set; }
    }
}
