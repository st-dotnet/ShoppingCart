using System.Collections.Generic;

namespace ShoppingProject.Data.Entities
{
   public class User:BaseEntity 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Roles { get; set; }
        public ICollection<UserAddress> UserAddresses { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
