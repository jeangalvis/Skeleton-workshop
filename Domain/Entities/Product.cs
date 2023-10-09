namespace Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public int IdWarehousefk { get; set; }
    public Warehouse Warehouse { get; set; }
}
