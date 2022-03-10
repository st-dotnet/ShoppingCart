using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface IUserAddress
    {
        Task<UserAddress> GetUserAddress(int UserAddressId);
        Task<UserAddress> GetUserAddrressList();
        Task<UserAddress> AddUserAddress();
        Task<UserAddress> UpdateUserAddress(int UserAddressId);
        Task<bool> DeleteUserAddress(int UserAddressId);
    }
}
