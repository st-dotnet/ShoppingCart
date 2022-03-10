using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface IProductCategory
    {
        Task<ProductCategory> GetProductCategory(int productCategoryId);
        Task<ProductCategory> GetProductCategoryList();
        Task<ProductCategory> AddProductCategory();
        Task<ProductCategory> UpdateProductCategory(int productCategoryId);
        Task<bool> DeleteProductCategory(int productCategoryId);
    }
}
