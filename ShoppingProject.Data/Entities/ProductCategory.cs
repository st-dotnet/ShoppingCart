
using System.Collections.Generic;

namespace ShoppingProject.Data.Entities
{
   public class ProductCategory:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId  { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
