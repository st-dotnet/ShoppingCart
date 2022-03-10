using ShoppingProject.Data;
using ShoppingProject.Data.Entities;
using ShoppingProject.Services.Interface;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Services
{
    public class RoleService : IRole
    {
       private readonly ShoppingDbContext _context;
        public RoleService(ShoppingDbContext context)
        {
            _context = context;      
        }
        public Task<Role> AddRole()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteRole(int RoleId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> GetRole(int RoleId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> GetRoleList()
        {
            throw new System.NotImplementedException();
        }

        public Task<Role> UpdateRole(int RoleId)
        {
            throw new System.NotImplementedException();
        }
    }
}
