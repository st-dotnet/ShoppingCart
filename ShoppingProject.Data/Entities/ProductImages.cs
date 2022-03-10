﻿
namespace ShoppingProject.Data.Entities
{
   public class ProductImages:BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }
        public Product Product { get; set; }
    }
}
