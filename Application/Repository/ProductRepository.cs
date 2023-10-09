using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public class ProductRepository : GenericRepository<Product>, IProduct
{
    private readonly SkeletonContext _context;
    public ProductRepository(SkeletonContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _context.Products
                        .Include(p => p.Warehouse)
                        .ToListAsync();
    }
}
