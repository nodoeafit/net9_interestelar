using Microsoft.EntityFrameworkCore;
using AppProductos.Models;

namespace AppProductos.Data;

public class AppDbContext: DbContext
{
    public DbSet<Producto> Productos { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }
}