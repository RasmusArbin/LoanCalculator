using System;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.BO
{
    public class LoanTypeBO: IBaseBO
    {
        public int Id => LoanTypeId;
        public int LoanTypeId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
