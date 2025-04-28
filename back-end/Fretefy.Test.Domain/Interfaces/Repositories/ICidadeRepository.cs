﻿using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository
    {
        IQueryable<Cidade> List();
        IEnumerable<Cidade> ListByUf(string uf);
        IEnumerable<Cidade> Query(string terms);
        Task<Cidade> GetCidadeById(Guid id);
    }
}
