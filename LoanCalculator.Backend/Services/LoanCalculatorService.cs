using System;
using System.Collections.Generic;
using System.Linq;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;
using LoanCalculator.Backend.Providers;

namespace LoanCalculator.Backend.Services
{
    /// <summary>
    /// Classes to handle business logic in the application.
    /// </summary>
    public class LoanCalculatorService
    {
        public LoanCalculatorRepositoryProvider RepositoryProvider;
    }
    public class LoanCalculatorService<T>: LoanCalculatorService 
        where T : IBaseBO
    {
        protected LoanCalculatorRepository<T> MainRepository => RepositoryProvider.GetRepository<T>();
        public List<T> GetAll()
        {
            return MainRepository.GetAll().ToList();
        }

        public void Remove(T entity)
        {
            MainRepository.Remove(entity);
        }

        public void Insert(T entity)
        {
            MainRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            MainRepository.Update(entity);
        }

        public T GetById(int id)
        {
            return MainRepository.GetById(id);
        }
    }
}