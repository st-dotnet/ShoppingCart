
namespace ShoppingProject.Data.Entities
{
   public class OrderItems:BaseEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Status { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int? SubTotal { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
