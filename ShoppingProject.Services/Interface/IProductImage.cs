using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface IProductImage
    {
        Task<ProductImages> GetProductImages(int ProductImagesId);
        Task<ProductImages> GetProductImagesList();
        Task<ProductImages> AddProductImages();
        Task<ProductImages> UpdateProductImages(int ProductImagesId);
        Task<bool> DeleteProductImages(int ProductImagesId);
    }
}
