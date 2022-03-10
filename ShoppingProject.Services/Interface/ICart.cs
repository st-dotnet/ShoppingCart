using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface ICart
    {
        Task<Cart> GetCart(int CartId);
        Task<Cart> GetCartList();
        Task<Cart> AddCart();
        Task<Cart> UpdateCart(int CartId);
        Task<bool> DeleteCart(int CartId);
    }
}
