using KO.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace KO.BLL
{
    public interface IServiceInterface<T>
          where T : BaseClass
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
