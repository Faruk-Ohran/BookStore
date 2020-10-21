using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Book : BaseEntity
    {
        public Book(string createdBy):base(createdBy)
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public List<Cart> Carts { get; set; }
        public List<BookCategory> Categories { get; set; }
        public List<Order> Orders { get; set; }
        public List<WishList> WishLists { get; set; }
    }
}
