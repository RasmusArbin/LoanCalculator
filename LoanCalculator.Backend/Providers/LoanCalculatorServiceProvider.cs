using System;
using System.Collections.Generic;
using LoanCalculator.Backend.Services;

namespace LoanCalculator.Backend.Providers
{
    public class LoanCalculatorServiceProvider: LoanCalculatorService
    {
        private readonly LoanCalculatorRepositoryProvider _repositoryProvider;
        private readonly Dictionary<Type, LoanCalculatorService> _services;

        public LoanCalculatorServiceProvider()
        {
            _services = new Dictionary<Type, LoanCalculatorService>();
            _repositoryProvider = new LoanCalculatorRepositoryProvider();
        }

        public T GetService<T>()
            where T : LoanCalculatorService, new()
        {
            LoanCalculatorService obj;
            _services.TryGetValue(typeof(T), out obj);

            if (obj == null)
            {
                obj = new T {RepositoryProvider = _repositoryProvider};
                _services.Add(typeof(T), obj);
            }

            return (T) obj;
        }
    }
}