using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("product");

        builder.Property(p => p.Name).HasColumnType("varchar").HasMaxLength(100).IsRequired();
        builder.Property(p => p.Stock).IsRequired();

        builder.HasOne(p => p.Warehouse)
        .WithMany(p => p.Products)
        .HasForeignKey(p => p.IdWarehousefk);
    }
}
