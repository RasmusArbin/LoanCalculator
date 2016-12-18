namespace LoanCalculator.Backend.Interfaces
{
    /// <summary>
    /// Interface to hide the implementation of the db context. 
    /// This to easy change and have a test db context.
    /// </summary>
    public interface IDbContext
    {
        IDbSet<T> GetDbSet<T>() where T : IBaseBO;
    }
}
