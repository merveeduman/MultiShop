using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService 
    {
            Task CreateProduct(CreateProductDto createProductDto);
            Task UpdateProduct(UpdateProductDto updateProductDto);
            Task DeleteProduct(string id);
            Task<ResultProductDto> GetProductById(string id);
            Task<List<ResultProductDto>> GetAllProducts();
    }
}
