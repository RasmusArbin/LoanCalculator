namespace LoanCalculator.Backend.Interfaces
{
    public interface IDbContext
    {
        IDbSet<T> GetDbSet<T>() where T : IBaseBO;
    }
}
