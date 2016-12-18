using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator.Backend.Interfaces
{
    /// <summary>
    /// Interfaces to hide the implementation of the db set. 
    /// This to easy change and have a test db set.
    /// </summary>
    public interface IDbSet
    {
        
    }
    public interface IDbSet<T>: IDbSet
        where T : IBaseBO
    {
        IQueryable<T> GetAll();
        void Remove(T entity);
        void Insert(T entity);
        void Update(T entity);
        T GetById(int id);
    }
}
