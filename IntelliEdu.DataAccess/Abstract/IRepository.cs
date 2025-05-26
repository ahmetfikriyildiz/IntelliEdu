using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        T GetByFilter(Expression<Func<T, bool>> predicate);
        int FilteredCount(Expression<Func<T, bool>> predicate);
        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
        void Delete(int id);
        void Create(T entity);
        void Update(T entity);
        int Count();
    }
}
