using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public List<BookCategory> BookCategory { get; set; }
        public List<Cart> Cart { get; set; }
        public List<WishList> WishList { get; set; }
        public List<Order> Order { get; set; }
        public Book Book { get; set; }
    }
}
