using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface IProduct
    {
        Task<Product> GetProduct(int ProductId);
        Task<Product> GetProductList();
        Task<Product> AddProduct();
        Task<Product> UpdateProduct(int ProductId);
        Task<bool> DeleteProduct(int ProductId);
    }
}
