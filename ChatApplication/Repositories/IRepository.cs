using System.Linq.Expressions;
namespace ChatApplication.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        TEntity Find(Func<TEntity, bool> predicate);
        void Insert(TEntity entity);
        void Delete(TEntity entityToDelete);

    }
}
