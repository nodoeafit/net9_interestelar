using AppProducts.Data;
using AppProducts.Models;
using Microsoft.EntityFrameworkCore;

namespace AppProducts.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) { 
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() => await _context.Products.Include(p => p.Category).Include(p => p.ProductDetail).ToListAsync();

        public async Task<Product?> GetByIdAsync(int id) => await _context.Products.Include(p => p.Category).Include(p => p.ProductDetail).FirstOrDefaultAsync(p => p.Id == id);

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

    }
}
