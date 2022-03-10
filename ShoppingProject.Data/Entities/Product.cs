using System.Collections.Generic;

namespace ShoppingProject.Data.Entities
{
   public class Product:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripiton { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public ICollection<OrderItems> OrdersItems { get; set; }
    }
}
