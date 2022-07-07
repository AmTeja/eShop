namespace eShop.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsnyc();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
