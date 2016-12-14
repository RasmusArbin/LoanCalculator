using System;
namespace LoanCalculator.Backend.Interfaces
{
    public interface IBaseBO
    {
        int Id { get; }
        DateTime Created { get; }
        DateTime Modified { get; }
    }
}
