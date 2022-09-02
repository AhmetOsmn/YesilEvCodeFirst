using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.Core.Repos
{
    public abstract class EfRepoBase<TContext, TEntity> :
        IDeletableRepo<TEntity>,
        IInsertableRepo<TEntity>,
        ISelectableRepo<TEntity>,
        IUpdatableRepo<TEntity>
        where TEntity : class
        where TContext : DbContext, new()
    {
        private readonly TContext _context;

        public EfRepoBase(TContext context)
        {
            _context = context;
        }

        public EfRepoBase()
        {
            _context = new TContext();
        }

        public TEntity Add(TEntity item)
        {
            return _context.Set<TEntity>().Add(item);
        }

        public List<TEntity> AddRange(List<TEntity> items)
        {
            return _context.Set<TEntity>().AddRange(items).ToList();
        }

        public TEntity Delete(TEntity item)
        {
            return _context.Set<TEntity>().Remove(item);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public List<TEntity> GetByCondition(Func<TEntity, bool> whereCondition)
        {
            return _context.Set<TEntity>().Where(whereCondition).ToList();
        }

        // todo: alt kisimdaki metot cok saglikli degil, duzenlenecek.
        public List<TEntity> GetByConditionWithInclude(Func<TEntity, bool> whereCondition, string table, string table2)
        {
            var result = _context.Set<TEntity>().Include(table).Include(table2).Where(whereCondition).ToList();
            return result;
        }
        public List<TEntity> GetByConditionWithInclude(Func<TEntity, bool> whereCondition, string table)
        {
            var result = _context.Set<TEntity>().Include(table).Where(whereCondition).ToList();
            return result;
        }

        public TEntity GetByID(object ID)
        {
            return _context.Set<TEntity>().Find(ID);
        }

        public void MySaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<TEntity>().Attach(item);
        }


    }
}
