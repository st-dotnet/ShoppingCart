using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface ICartItem
    {
        Task<CartItem> GetCartItem(int CartItemId);
        Task<CartItem> GetCartItemList();
        Task<CartItem> AddCartItem();
        Task<CartItem> UpdateCartItem(int CartItemId);
        Task<bool> DeleteCartItem(int CartItemId);
    }
}
