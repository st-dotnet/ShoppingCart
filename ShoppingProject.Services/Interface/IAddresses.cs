using ShoppingProject.Data.Entities;
using System.Threading.Tasks;

namespace ShoppingProject.Services.Interface
{
   public interface IAddresses
    {
        Task<Addresses> GetAddresses(int AddressesId);
        Task<Addresses> GetAddressesList();
        Task<Addresses> AddAddress();
        Task<Addresses> UpdateAddresses(int AddressesId);
        Task<bool> DeleteAddresses(int AddressesId);

    }
}
