using System;
namespace LoanCalculator.Backend.Interfaces
{
    /// <summary>
    /// Interface that every BO must implement
    /// </summary>
    public interface IBaseBO
    {
        int Id { get; }
        DateTime Created { get; }
        DateTime Modified { get; }
    }
}
