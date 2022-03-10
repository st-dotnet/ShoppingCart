using System;
using System.Collections.Generic;

namespace ShoppingProject.Data.Entities
{
  public class Order:BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public int Total { get; set; }
        public int PaymentMethod { get; set; }
        public int TransactioId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionStatus { get; set; }
        public User User { get; set; }
        public ICollection<OrderItems> OrdersItems { get; set; }
    }
}
