using System;
using System.Collections.Generic;
using LoanCalculator.Backend.BO;

namespace LoanCalculator.Backend.Services
{
    public class LoanTypeService: LoanCalculatorService
    {
        private static LoanTypeBO _loanType = new LoanTypeBO()
        {
            LoanTypeId = 1,
            Guid = Guid.NewGuid(),
            Name = "Huslån",
            Percent = 3.5,
            Created = DateTime.Now,
            Modified = DateTime.Now
        };
        public List<LoanTypeBO> GetAllLoanTypes()
        {
            return new List<LoanTypeBO>()
            {
                _loanType
            };
        }

        public LoanTypeBO GetByGuid(Guid loanTypeGuid)
        {
            return _loanType;
        }

        /// <summary>
        /// Gets a payment plan that tells the user how much he or she must pay back to be dept free after desired year count
        /// </summary>
        /// <param name="loanAmount">Total amoun loaned from bank</param>
        /// <param name="yearCount">The desired year count to pay back the loan</param>
        /// <returns>How much money the user must pay every month to to be out of dept after desired year count</returns>
        public double CalculatePaymentPlan(Guid loanTypeGuid, double loanAmount, int yearCount)
        {
            LoanTypeBO loanType = GetByGuid(loanTypeGuid);

            int monthCount = GetMonth(yearCount);

            return CalculateTotalAmmountToPayBack(loanAmount, monthCount, loanType.Percent) / monthCount;
        }

        /// <summary>
        /// Get total amount to pay back to the bank
        /// </summary>
        /// <param name="loanAmount">Total amoun loaned from bank</param>
        /// <param name="monthCount">The desired month count to pay back the loan</param>
        /// <param name="percent">The interest on the loan</param>
        /// <returns>Total amount of dept after a certan year count</returns>
        private double CalculateTotalAmmountToPayBack(double loanAmount, int monthCount, double percent)
        {
            double copiedLoanAmount = loanAmount;
            double totalInterestAmount = 0;
            double amortization = copiedLoanAmount/monthCount;
            for (int i = 0; i < monthCount; i++)
            {
                totalInterestAmount += copiedLoanAmount*percent/100/12;
                copiedLoanAmount -= amortization;
            }

            return loanAmount + totalInterestAmount;
        }

        private int GetMonth(int years)
        {
            return years*12;
        }
    }
}