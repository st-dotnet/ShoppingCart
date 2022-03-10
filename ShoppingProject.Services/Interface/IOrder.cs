using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface IOrder
    {
        Task<Order> GetOrder(int OrderId);
        Task<Order> GetOrderList();
        Task<Order> AddOrder();
        Task<Order> UpdateOrder(int OrderId);
        Task<bool> DeleteOrder(int OrderId);
    }
}
