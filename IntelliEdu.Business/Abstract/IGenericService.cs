using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IntelliEdu.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetById(int id);
        T TGetByFilter(Expression<Func<T, bool>> predicate);
        int TFilteredCount(Expression<Func<T, bool>> predicate);
        List<T> TGetFilteredList(Expression<Func<T, bool>> predicate);
        void TDelete(int id);
        void TCreate(T entity);
        void TUpdate(T entity);
        int TCount();
    }
}
