using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Domain
{
    public class Order : BaseEntity
    {
        public int BookId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
