using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;
using LoanCalculator.Backend.Enums;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.General
{
    /// <summary>
    /// Class to handle the database context. 
    /// 
    /// NOTE: The structure of this backend is flexible. To use a database just change this implementation and LoanCalculatorDbSet (or the provider)
    /// </summary>
    public class LoanCalculatorDbContext: IDbContext
    {
        private static readonly Dictionary<Type, IDbSet> _dbSets;
        static LoanCalculatorDbContext()
        {
            _dbSets = new Dictionary<Type, IDbSet>
            {
                {
                    typeof(LoanTypeBO), new LoanCalculatorDbSet<LoanTypeBO>(new List<LoanTypeBO>
                    {
                        new LoanTypeBO()
                        {
                            LoanTypeId = (int) LoanTypeEnum.HouseLoan,
                            Guid = Guid.NewGuid(),
                            Name = "House loan",
                            Percent = 3.5,
                            Created = DateTime.Now,
                            Modified = DateTime.Now
                        }
                    })
                },
                {
                    typeof(PaymentSchemeTypeBO),
                    new LoanCalculatorDbSet<PaymentSchemeTypeBO>(new List<PaymentSchemeTypeBO>
                    {
                        new PaymentSchemeTypeBO()
                        {
                            PaymentSchemeTypeId = (int) PaymentSchemeTypeEnum.Monthly,
                            Guid = Guid.NewGuid(),
                            Name = "Monthly",
                            Created = DateTime.Now,
                            Modified = DateTime.Now
                        }
                    })
                }
            };
        }
        public IDbSet<T> GetDbSet<T>() 
            where T : IBaseBO
        {
            return (IDbSet<T>) _dbSets[typeof(T)];
        }

        public void Dispose()
        {
            //Implement to close db connection
        }
    }
}
