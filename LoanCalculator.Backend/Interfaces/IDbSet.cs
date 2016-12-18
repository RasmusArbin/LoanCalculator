using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator.Backend.Interfaces
{
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
