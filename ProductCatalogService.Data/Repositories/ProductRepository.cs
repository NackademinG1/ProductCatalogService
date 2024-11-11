﻿using ProductCatalogService.Data.Interfaces;
using ProductCatalogService.Data.Models;

namespace ProductCatalogService.Data.Repositories;

public class ProductRepository : IProductRepository
{
    public IEnumerable<Product> GetAllProducts()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Product A" },
            new Product { Id = 2, Name = "Product B" }
        };
    }
}