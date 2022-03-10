using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface IUser
    {
        Task<User> GetUser(int userId);
        Task<User> GetUserList();
        Task<User> AddUser();
        Task<User> Update(int UserId);
        Task<bool> Delete(int userId);
    }
}
