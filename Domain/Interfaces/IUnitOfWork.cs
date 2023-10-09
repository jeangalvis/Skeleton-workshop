namespace Domain.Interfaces;
public interface IUnitOfWork
{
    IProduct Products { get; }
    Task<int> SaveAsync();
}
