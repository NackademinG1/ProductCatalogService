namespace ProductCatalogService.Business.Interfaces;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}
