using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace MisrNews.Repository
{
    public class Repository<TContext, TEntity> : IRepository<TEntity>, IDisposable
        where TContext : DbContext, new()
        where TEntity : class
    {
        private TContext _dataContext;

        #region MyRegion

        public virtual TContext DataContext
        {
            get
            {
                if (_dataContext == null)
                {
                    _dataContext = new TContext();
                    AllowSerialization = false;
                }
                return _dataContext;
            }
            set { _dataContext = value; }
        }

        public void Dispose()
        {
            if (DataContext != null)
                DataContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool AllowSerialization
        {
            get { return _dataContext.Configuration.ProxyCreationEnabled; }
            set { _dataContext.Configuration.ProxyCreationEnabled = !value; }
        }

        #endregion

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList()
        {
            return DataContext.Set<TEntity>().ToList<TEntity>();
        }

        public List<TEntity> GetList(out int total)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, out int total)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate,
                                           Expression<Func<TEntity, TKey>> orderBy)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate,
                                           Expression<Func<TEntity, TKey>> orderBy, out int total)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate,
                                           Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList<TKey>(Expression<Func<TEntity, bool>> predicate,
                                           Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize,
                                           out int total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync(out int total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate, out int total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                      Expression<Func<TEntity, TKey>> orderBy)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                      Expression<Func<TEntity, TKey>> orderBy, out int total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                      Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetListAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                      Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize,
                                                      out int total)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find<TKey>(Expression<Func<TEntity, bool>> predicate,
                                        Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Find<TKey>(Expression<Func<TEntity, bool>> predicate,
                                        Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize, out int total)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> FindAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                   Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> FindAsync<TKey>(Expression<Func<TEntity, bool>> predicate,
                                                   Expression<Func<TEntity, TKey>> orderBy, int pageNo, int pageSize,
                                                   out int total)
        {
            throw new NotImplementedException();
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public int Total(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> TotalAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public OperationStatus Save(TEntity entity)
        {
            var opStatus = new OperationStatus { Status = true };
            try
            {
                DataContext.Set<TEntity>().Add(entity);
                opStatus.Status = DataContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                opStatus = OperationStatus.CreateFromException("Error saving!", ex);
            }
            return opStatus;
        }

        public OperationStatus SaveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public OperationStatus Update(TEntity entity, params string[] props)
        {
            throw new NotImplementedException();
        }

        public OperationStatus UpdateAsync(TEntity entity, params string[] props)
        {
            throw new NotImplementedException();
        }

        public OperationStatus Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public OperationStatus DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

    }
}