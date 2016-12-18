using System.Linq;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.General
{
    /// <summary>
    /// Classes to handle CRUD from the database
    /// </summary>
    public class LoanCalculatorRepository
    {
        
    }
    public class LoanCalculatorRepository<T>: LoanCalculatorRepository
        where T: IBaseBO
    {
        private IDbSet<T> _dbSet;

        public static LoanCalculatorRepository<T> GetInstance(IDbSet<T> dbSet)
        {
            LoanCalculatorRepository<T> repository = new LoanCalculatorRepository<T> {_dbSet = dbSet};
            return repository;
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.GetAll();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Insert(T entity)
        {
            _dbSet.Insert(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T GetById(int id)
        {
            return _dbSet.GetById(id);
        }
    }
}
