using AppProductos.Models;
using AppProductos.Repositories;

namespace AppProductos.Services;

public interface IProductoService
{
    IEnumerable<Producto> ObtenerTodos(string? criterio, int pagina, int tamanoPagina, out int totalProductos);
    Producto ObtenerPorId(int id);
    void Agregar(Producto producto);
    void Actualizar(Producto producto);
    void Eliminar(int id);
}

public class ProductoService : IProductoService
{
    private readonly IProductoRepository _productoRepository;

    public ProductoService(IProductoRepository productoRepository)
    {
        _productoRepository = productoRepository;
    }

    public IEnumerable<Producto> ObtenerTodos(string? criterio, int pagina, int tamanoPagina, out int totalProductos)
    {
        var productos = _productoRepository.ObtenerTodos();

        if (!string.IsNullOrWhiteSpace(criterio)) {
            productos = productos.Where(p =>
                p.Nombre.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                p.Categoria.Contains(criterio, StringComparison.OrdinalIgnoreCase)
            );
        }

        totalProductos = productos.Count();

        return productos
            .Skip((pagina - 1) * tamanoPagina)
            .Take(tamanoPagina);
    }

    public void Agregar(Producto producto)
    {
        _productoRepository.Agregar(producto);
    }

    public Producto ObtenerPorId(int id) { 
        return _productoRepository.ObtenerPorId(id);
    }

    public void Actualizar(Producto producto)
    {
        _productoRepository.Actualizar(producto);
    }

    public void Eliminar(int id)
    {
        _productoRepository.Eliminar(id);
    }
}