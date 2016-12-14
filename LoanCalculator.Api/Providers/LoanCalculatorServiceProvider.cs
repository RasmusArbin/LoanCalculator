using System.Collections.Generic;
using LoanCalculator.Api.Services;

namespace LoanCalculator.Api.Providers
{
    public class LoanCalculatorServiceProvider: LoanCalculatorService
    {
        private readonly Dictionary<string, LoanCalculatorService> _services;

        public LoanCalculatorServiceProvider()
        {
            _services = new Dictionary<string, LoanCalculatorService>();
        }

        public T GetService<T>()
            where T : LoanCalculatorService, new()
        {
            string fullName = typeof(T).FullName;
            LoanCalculatorService obj;
            _services.TryGetValue(typeof(T).FullName, out obj);

            if (obj == null)
            {
                obj = new T();
                _services.Add(fullName, obj);
            }

            return (T)obj;
        }
    }
}