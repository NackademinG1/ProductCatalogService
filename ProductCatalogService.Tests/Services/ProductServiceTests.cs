using Moq;
using ProductCatalogService.Business.Interfaces;
using ProductCatalogService.Business.Services;
using ProductCatalogService.Data.Interfaces;
using ProductCatalogService.Data.Models;

namespace ProductCatalogService.Tests.Services
{
    public class ProductServiceTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;
        private readonly IProductService _productService;

        public ProductServiceTests()
        {
            _productRepositoryMock = new Mock<IProductRepository>();
            _productService = new ProductService(_productRepositoryMock.Object);
        }

        [Fact]
        public void GetProducts_ReturnsProductList()
        {
            // Arrange
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Test Product" }
            };

            _productRepositoryMock.Setup(repo => repo.GetAllProducts()).Returns(products);

            // Act
            var result = _productService.GetProducts();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("Test Product", result.First().Name);
        }
    }
}
