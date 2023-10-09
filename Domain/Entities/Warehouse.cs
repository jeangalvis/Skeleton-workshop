namespace Domain.Entities;
public class Warehouse : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }
}
