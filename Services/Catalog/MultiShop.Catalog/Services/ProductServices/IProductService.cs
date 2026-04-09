using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService 
    {
            Task CreateProductAsync(CreateProductDto createProductDto);
            Task UpdateProductAsync(UpdateProductDto updateProductDto);
            Task DeleteProductAsync(string id);
            Task<ResultProductDto> GetByIdProductAsync(string id);
            Task<List<ResultProductDto>> GetAllProductsAsync();
    }
}
