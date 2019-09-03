using Sy.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Sy.DataAccess;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Sy.Business
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class,IEntity<TKey>
    {
            private readonly StockContext _context;
            private readonly DbSet<TEntity> _table;
        public Repository()
        {
            _context = new StockContext();
            _table = _context.Set<TEntity>();
        }

                


        public int Delete(TEntity entity)
        {
            _table.Remove(entity);
            return this.Save();
          
        }

        public IEntity GetById(TKey id)
        {
            return _table.Find(Id);
        }

        public TKey Insert(TEntity entity)
        {
            _table.Add(entity);
            this.Save();
            return entity.Id;
        }

        public IQueryable<IEntity> Query(Expression<Func<TEntity, bool>> predicate = null)
        {
            return predicate == null ? _table : _table.Where(predicate);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _table.AddOrUpdate(entity);
            return this.Save();
        }
    }
}
