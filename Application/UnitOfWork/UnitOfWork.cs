using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly SkeletonContext context;
    public IProduct _products;
    public UnitOfWork(SkeletonContext _context)
    {
        context = _context;
    }

    public IProduct Products{
        get {
            if(_products == null){
                _products = new ProductRepository(context);
            }
            return _products;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
