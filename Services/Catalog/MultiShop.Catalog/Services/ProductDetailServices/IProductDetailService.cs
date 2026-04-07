using MultiShop.Catalog.Dtos.ProductDetailsDtos;

namespace MultiShop.Catalog.Services.ProductDetailServices
{
    public interface IProductDetailService
    {

        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string id);
        Task<ResultProductDetailDto> GetProductDetailByIdAsync(string id);
    }
}
