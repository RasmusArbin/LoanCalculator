using System.Collections.Generic;
using System.Linq;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.General
{
    public class LoanCalculatorDbSet<T>: IDbSet<T> 
        where T : IBaseBO
    {
        private readonly List<T> _entities;
        public LoanCalculatorDbSet(List<T> entites)
        {
            _entities = entites;
        }
        public IQueryable<T> GetAll()
        {
            return _entities.AsQueryable();
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            //Do not need to be implemented
        }

        public T GetById(int id)
        {
            return _entities.Find(e => e.Id == id);
        }
    }
}
