using ShoppingProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface IProductCategory
    {
        Task<ProductCategory> GetProductCategory(int productCategoryId);
        Task<ProductCategory> GetProductCategoryList();
        Task<ProductCategory> AddProductCategory();
        Task<ProductCategory> UpdateProductCategory();
        Task<bool> DeleteProductCategory(int productCategoryId);
    }
}
