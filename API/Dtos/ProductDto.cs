namespace API.Dtos;
public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public int IdWarehousefk { get; set; }
}
