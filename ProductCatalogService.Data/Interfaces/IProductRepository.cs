using ProductCatalogService.Data.Models;

namespace ProductCatalogService.Data.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}
