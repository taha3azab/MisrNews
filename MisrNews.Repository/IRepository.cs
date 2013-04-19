using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace MisrNews.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        TEntity Single(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);


        List<TEntity> GetList();
        List<TEntity> GetList(out int total);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, out int total);
        List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy);
        List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, out int total);
        List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize);
        List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize, out int total);


        Task<List<TEntity>> GetListAsync();
        Task<List<TEntity>> GetListAsync(out int total);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, out int total);
        Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy);
        Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, out int total);
        Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize);
        Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize, out int total);


        List<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> Find<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize);
        List<TEntity> Find<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize, out int total);

        Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> FindAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize);
        Task<List<TEntity>> FindAsync<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize, out int total);


        TEntity First(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        int Total(Expression<Func<TEntity, bool>> predicate);
        Task<int> TotalAsync(Expression<Func<TEntity, bool>> predicate);

        OperationStatus Save(TEntity entity);
        OperationStatus SaveAsync(TEntity entity);

        OperationStatus Update(TEntity entity, params string[] props);
        OperationStatus UpdateAsync(TEntity entity, params string[] props);

        OperationStatus Delete(TEntity entity);
        OperationStatus DeleteAsync(TEntity entity);

    }
}
