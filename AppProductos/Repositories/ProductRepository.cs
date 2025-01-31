using AppProductos.Data;
using AppProductos.Models;

namespace AppProductos.Repositories;

public interface IProductoRepository
{
    IEnumerable<Producto> ObtenerTodos();
    Producto ObtenerPorId(int id);
    void Agregar(Producto producto);
    void Actualizar(Producto producto);
    void Eliminar(int id);
}

public class ProductoRespository : IProductoRepository 
{
    private readonly AppDbContext _context;

    public ProductoRespository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Producto> ObtenerTodos() => _context.Productos.ToList();

    public void Agregar(Producto producto)
    {
        _context.Productos.Add(producto);
        _context.SaveChanges();
    }

    public Producto ObtenerPorId(int id) => _context.Productos.Find(id);

    public void Actualizar(Producto producto)
    {
        _context.Productos.Update(producto);
        _context.SaveChanges();
    }

    public void Eliminar(int id)
    {
        var producto = ObtenerPorId(id);
        if (producto != null)
        {
            _context.Productos.Remove(producto);
            _context.SaveChanges();
        }
    }
}