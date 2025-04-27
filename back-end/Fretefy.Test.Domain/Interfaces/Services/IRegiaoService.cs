using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IRegiaoService
    {
        Task<Regiao> GetRegiaoById(Guid id);
        Task<IEnumerable<Regiao>> ListRegioes(int page, int pageSize);

        Task<Regiao> NovaRegiao(NovaRegiaoDto dto);
        Task<Regiao> EditarRegiaoDto(EditarRegiaoDto dto);
    }
}
