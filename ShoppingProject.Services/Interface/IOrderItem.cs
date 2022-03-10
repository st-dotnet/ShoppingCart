using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface IOrderItem
    {
        Task<OrderItems> GetOrderItems(int OrderItemsId);
        Task<OrderItems> GetOrderItemsList();
        Task<OrderItems> AddOrderItems();
        Task<OrderItems> UpdateOrderItems(int OrderItemsId);
        Task<bool> DeleteOrderItems(int OrderItemsId);
    }
}
