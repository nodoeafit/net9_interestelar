namespace AppProductos.Models;

public class Producto
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public required string Categoria { get; set; }
}