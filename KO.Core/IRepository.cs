using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.Core
{
    public interface IRepository<T, DBContext> where T : BaseClass where DBContext : DbContext
    {
        int Add(T entity);
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
        void Update(T entity);
        void Delete(int id);
        ICollection<T> All();
        ICollection<T> All(Expression<Func<T, bool>> predicate);
    }
}
