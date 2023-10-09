using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class SkeletonContext : DbContext
{
    public SkeletonContext(DbContextOptions<SkeletonContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
}