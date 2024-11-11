using ProductCatalogService.Business.Interfaces;
using ProductCatalogService.Business.Services;
using ProductCatalogService.Data.Interfaces;
using ProductCatalogService.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();