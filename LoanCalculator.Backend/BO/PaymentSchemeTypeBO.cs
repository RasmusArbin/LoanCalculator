using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanCalculator.Backend.Interfaces;

namespace LoanCalculator.Backend.BO
{
    public class PaymentSchemeTypeBO: IBaseBO
    {
        public int Id => PaymentSchemeTypeId;
        public int PaymentSchemeTypeId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
