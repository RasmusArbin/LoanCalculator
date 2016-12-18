using System;
using System.Collections.Generic;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Providers
{
    public class LoanCalculatorRepositoryProvider
    {
        private readonly Dictionary<Type, LoanCalculatorRepository> _repositories;
        private readonly IDbContext _dbContext;

        public LoanCalculatorRepositoryProvider()
        {
            _dbContext = new LoanCalculatorDbContext();
            _repositories = new Dictionary<Type, LoanCalculatorRepository>();
        }
        public LoanCalculatorRepository<T> GetRepository<T>() 
            where T : IBaseBO
        {
            LoanCalculatorRepository obj;
            _repositories.TryGetValue(typeof(T), out obj);

            if (obj == null)
            {
                obj = LoanCalculatorRepository<T>.GetInstance(_dbContext.GetDbSet<T>());
                _repositories.Add(typeof(T), obj);
            }

            return (LoanCalculatorRepository<T>) obj;
        }
    }
}
