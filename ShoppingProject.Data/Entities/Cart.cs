using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingProject.Data.Entities
{
   public class Cart : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }  
        public int? Total { get; set; }
        public int Quantity { get; set; }

        public User User { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
