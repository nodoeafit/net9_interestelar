using AppProducts.Models;
using AppProducts.Repositories;

namespace AppProducts.Services
{
    public class ProductService: IProductService
    {
        public readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync() => await _productRepository.GetAllAsync();

        public async Task AddProductAsync(Product product) => await _productRepository.AddAsync(product);

    }
}
