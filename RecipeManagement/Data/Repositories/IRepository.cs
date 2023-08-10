using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManagement.Data.Repositories
{
    public interface IRepository<T>
        where T : class, new()
    {
        IEnumerable<T> Retrieve();
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        IEnumerable<T> Retrieve(Expression<Func<T, bool>> conditions);
        IEnumerable<T> Retrieve(params Expression<Func<T, object>>[] includes);
        IEnumerable<T> Retrieve(Expression<Func<T, bool>> conditions,
            params Expression<Func<T, object>>[] includes);
        T SearchOnPK<TPrimaryKey>(TPrimaryKey id);
        int AddOrUpdate(T entity);
        int TAddRange(IEnumerable<T> entities);
        int Delete<TPrimaryKey>(TPrimaryKey id);
        int DeleteRange(IEnumerable<T> entities);
    }
}
