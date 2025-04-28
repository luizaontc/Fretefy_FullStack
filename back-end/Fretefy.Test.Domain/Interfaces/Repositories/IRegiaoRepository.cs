using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        Task<Regiao> AdicionarRegiao(Regiao entity);
        Task<Regiao> AtualizarRegiao(Regiao entity);
        Task<Regiao> GetRegiaoById(Guid id);
        Task<IEnumerable<Regiao>> GetRegiao(int page, int pageSize);
        Task<bool> ExisteRegiao(string nomeRegiao, Guid? IdRegiao);
        Task<IEnumerable<RegiaoCidade>> AdicionarRegiaoCidades(List<RegiaoCidade> entities);
        Task<IEnumerable<RegiaoCidade>> GetRegiaoCidades(Guid idRegiao);
        Task<IEnumerable<RegiaoCidade>> RemoverRegiaoCidade(List<RegiaoCidade> entities, Guid idRegiao);
    }
}
