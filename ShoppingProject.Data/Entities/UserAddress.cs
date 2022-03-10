
namespace ShoppingProject.Data.Entities
{
  public class UserAddress:BaseEntity
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public Addresses Addresses { get; set; }
        public User Users { get; set; }
    }
}
