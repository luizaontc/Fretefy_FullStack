using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        Regiao NewRegiao(Regiao regiao);
        Task<List<RegiaoCidade>> NewRegiaoCidade(List<RegiaoCidade> regiaoCidade);
        IQueryable<Regiao> List();
        IEnumerable<Regiao> ListByName(string name);
        IEnumerable<Regiao> Query(string terms);
        Regiao ChangeStatus(Regiao regiao);
    }
}
