using Contracts;
using Microsoft.EntityFrameworkCore;
using Shared.DataTransferObjects;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext)
        => RepositoryContext = repositoryContext;

        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
               RepositoryContext.Set<T>()
                    .AsNoTracking() :
               RepositoryContext.Set<T>();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges) =>
            !trackChanges ?
                RepositoryContext.Set<T>()
                    .Where(expression)
                    .AsNoTracking() :
                RepositoryContext.Set<T>()
                    .Where(expression);

        public async Task<IEnumerable<MatchHistoryDto>> GetAllHamsterMatches()
        {
            var list = await (from md in RepositoryContext.Matches
                              join winner in RepositoryContext.Hamsters on md.WinnerId equals winner.Id
                              join loser in RepositoryContext.Hamsters on md.LoserId equals loser.Id
                              select new MatchHistoryDto
                              {
                                  Id = md.Id,
                                  Winner = winner,
                                  Loser = loser,
                              }).ToListAsync();
            return list;
                              
        }
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
