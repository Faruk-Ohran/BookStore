using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Order
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime DateTime { get; set; }
        public float Total { get; set; }
        public string PaymentMethod { get; set; }
    }
}
