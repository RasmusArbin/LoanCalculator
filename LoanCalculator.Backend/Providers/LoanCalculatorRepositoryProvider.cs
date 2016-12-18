using System;
using System.Collections.Generic;
using LoanCalculator.Backend.General;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.Providers
{
    /// <summary>
    /// This class has the reponsibility to provide the different repositories in the system.
    /// </summary>
    public class LoanCalculatorRepositoryProvider
    {
        private readonly Dictionary<Type, LoanCalculatorRepository> _repositories;
        private readonly IDbContext _dbContext;

        public LoanCalculatorRepositoryProvider(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
