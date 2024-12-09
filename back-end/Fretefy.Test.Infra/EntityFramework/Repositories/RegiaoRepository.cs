using Fretefy.Test.Domain.Dto;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private DbSet<Regiao> _dbSet;
        private DbSet<RegiaoCidade> _dbSetRC;
        private readonly DbContext _dbContext;

        public RegiaoRepository(DbContext dbSet, DbContext dbContext)
        {
            _dbSet = dbSet.Set<Regiao>();
            _dbSetRC = dbSet.Set<RegiaoCidade>();
            _dbContext = dbContext;
        }

        public IQueryable<Regiao> List()
        {
            return _dbSet.AsQueryable();
        }

        public IEnumerable<Regiao> ListByName(string nome)
        {
            return _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{nome}%"));
        }

        public Regiao NewRegiao(Regiao regiao)
        {
            var entityEntry = _dbSet.Add(regiao);
            _dbContext.SaveChanges();
            return entityEntry.Entity;             
        }

        public IEnumerable<Regiao> Query(string terms)
        {

            return _dbSet.Where(w => EF.Functions.Like(w.Nome, $"%{terms}%") || EF.Functions.Like(w.Nome, $"%{terms}%"));
        }

        public Regiao ChangeStatus(Regiao regiao)
        {
            var entityEntry = _dbSet.Update(regiao);
            _dbContext.SaveChanges();
            return entityEntry.Entity;
        }

        public async Task<List<RegiaoCidade>> NewRegiaoCidade(List<RegiaoCidade> regiaoCidade)
        {
            await _dbSetRC.AddRangeAsync(regiaoCidade);
            _dbContext.SaveChanges();
            return regiaoCidade;
        }
    }
}
