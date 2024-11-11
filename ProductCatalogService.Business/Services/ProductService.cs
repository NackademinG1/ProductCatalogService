﻿using ProductCatalogService.Business.Interfaces;
using ProductCatalogService.Data.Interfaces;
using ProductCatalogService.Data.Models;

namespace ProductCatalogService.Business.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _productRepository.GetAllProducts();
    }
}

