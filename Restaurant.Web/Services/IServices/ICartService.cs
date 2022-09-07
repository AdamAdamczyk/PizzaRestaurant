using Restaurant.Web.Models;

namespace Restaurant.Web.Services.IServices
{
    public interface ICartService
    {
        Task<T> GetCartByUserIdAsync<T>(string userId, string token = null);
        Task<T> AddToCartAsync<T>(CartDto cartDto, string userId, string token = null);
        Task<T> UpdateToCartAsync<T>(CartDto cartDto, string userId, string token = null);
        Task<T> RemoveToCartAsync<T>(int cartId, string userId, string token = null);
    }
}
