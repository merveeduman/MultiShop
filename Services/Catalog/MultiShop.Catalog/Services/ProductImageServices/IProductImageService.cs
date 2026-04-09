using MultiShop.Catalog.Dtos.ProductImageDtos;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageService
    {

            Task<ResultProductImageDto> CreateProductImageAsync(CreateProductImageDto createProductImageDto);
            Task<ResultProductImageDto> GetByIdProductImageAsync(string id);
            Task<List<ResultProductImageDto>> GetAllProductImagesAsync();
            Task<ResultProductImageDto> UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
            Task DeleteProductImageAsync(string id);
    }
}
