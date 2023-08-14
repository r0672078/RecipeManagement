using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RecipeManagement.Data.Repositories
{
    public class Repository<T> : IRepository<T>
        where T : class, new()
    {
        protected DbContext Context { get; }

        public Repository(DbContext context)
        {
            this.Context = context;
        }

        public IEnumerable<T> Retrieve()
        {
            return Context.Set<T>().ToList();
        }

        public int Add(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            return Context.SaveChanges();
        }

        public int Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChanges();
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return Context.SaveChanges();
        }

        public IEnumerable<T> Retrieve(Expression<Func<T, bool>> conditions,
           params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Context.Set<T>();
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            if (conditions != null)
            {
                query = query.Where(conditions);
            }
            return query.ToList();
        }

        public IEnumerable<T> Retrieve(Expression<Func<T, bool>> conditions)
        {
            return Retrieve(conditions, null).ToList();
        }

        public IEnumerable<T> Retrieve(params Expression<Func<T, object>>[] includes)
        {
            return Retrieve(null, includes).ToList();
        }

        public T SearchOnPK<TPrimaryKey>(TPrimaryKey id)
        {
            return Context.Set<T>().Find(id);
        }

        public int AddOrUpdate(T entity)
        {
            Context.Set<T>().Update(entity);
            return Context.SaveChanges();
        }

        public int TAddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
            return Context.SaveChanges();
        }

        public int Delete<TPrimaryKey>(TPrimaryKey id)
        {
            var entity = SearchOnPK(id);
            Context.Set<T>().Remove(entity);
            return Context.SaveChanges();
        }

        public int DeleteRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
            return Context.SaveChanges();
        }
    }
}
