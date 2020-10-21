using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Order:BaseEntity
    {
        public Order(string createdBy):base(createdBy)
        {

        }
        public int UserID { get; set; }
        public User User { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime DateTime { get; set; }
        public float Total { get; set; }
        public string PaymentMethod { get; set; }
    }
}
