using ProductCatalogService.Data.Models;

namespace ProductCatalogService.Business.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}
