using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
  public  interface IRole
    {
        Task<Role> GetRole(int RoleId);
        Task<Role> GetRoleList();
        Task<Role> AddRole();
        Task<Role> UpdateRole(int RoleId);
        Task<bool> DeleteRole(int RoleId);
    }
}
