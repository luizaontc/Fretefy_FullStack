using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Entities
{
    public class RegiaoCidade : IEntity
    {
        public RegiaoCidade()
        {

        }
        public RegiaoCidade(Guid idRegiao, Guid idCidade)
        {
            IdRegiao = idRegiao;
            IdCidade = idCidade;
        }

        public Guid Id { get; set; }

        public Guid IdRegiao { get; set; }
        public Guid IdCidade { get; set; }

    }
}
