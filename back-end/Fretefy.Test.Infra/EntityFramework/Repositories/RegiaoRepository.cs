using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private DbSet<Regiao> _dbSet;
        private DbSet<RegiaoCidade> _dbSetRegiaoCidade;
        private readonly DbContext _dbContext;

        public RegiaoRepository(DbContext dbContext)
        {
            _dbSet = dbContext.Set<Regiao>();
            _dbSetRegiaoCidade = dbContext.Set<RegiaoCidade>();
            _dbContext = dbContext;
        }

        public async Task<Regiao> AdicionarRegiao(Regiao entity)
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<RegiaoCidade>> AdicionarRegiaoCidades(List<RegiaoCidade> entities)
        {
            _dbSetRegiaoCidade.AddRange(entities);
            await _dbContext.SaveChangesAsync();
            return entities;
        }

        public async Task<Regiao> AtualizarRegiao(Regiao entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> ExisteRegiao(string nomeRegiao)
        {
            var response = await _dbSet.AnyAsync(x => x.Nome == nomeRegiao);

            return response;
        }

        public async Task<IEnumerable<Regiao>> GetRegiao(int page, int pageSize)
        {
            return await _dbSet
                .OrderBy(x => x.Nome)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<Regiao> GetRegiaoById(Guid id)
        {
            return await _dbSet.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RegiaoCidade>> GetRegiaoCidades(Guid idRegiao)
        {
            return await _dbSetRegiaoCidade.Where(x => x.Id == idRegiao).ToListAsync();
        }

        public async Task<IEnumerable<RegiaoCidade>> RemoverRegiaoCidade(List<RegiaoCidade> entities, Guid idRegiao)
        {
            _dbSetRegiaoCidade.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();

            return await GetRegiaoCidades(idRegiao);
        }
    }
}
