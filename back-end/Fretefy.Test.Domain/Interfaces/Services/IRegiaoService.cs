using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IRegiaoService
    {
        Regiao Get(Guid id);
        Regiao NewRegiao(RegiaoDTO dto);
        Regiao UpdateRegiao(RegiaoDTO dto);
        IEnumerable<Regiao> List();
        IEnumerable<Regiao> ListByName(string name);
        IEnumerable<Regiao> Query(string terms);
        Regiao ChangeStatus(string nome);
    }
}
