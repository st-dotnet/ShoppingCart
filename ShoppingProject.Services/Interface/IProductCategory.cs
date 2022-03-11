using ShoopingProject.Services.DTOs;
using System.Collections.Generic;

namespace ShoppingProject.Services.Interface
{
    public  interface IProductCategory
    {
        //get all product categories
        List<ProductCategoryResponse> GetProductCategories();

        //get product category by id
        ProductCategoryResponse GetProductCategoryById(int categoryId);

        //add product category
        bool AddProductCategory(ProductCategoryRequest request);

        //update product category
        bool UpdateProductCategory(ProductCategoryRequest request);

        //detele product category by category id
        bool DeleteProductCategory(int categoryId);
    }
}
