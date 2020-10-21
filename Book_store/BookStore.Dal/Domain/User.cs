using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<Cart> Carts { get; set; }
        public List<WishList> WishLists { get; set; }
        public List<Order> Orders { get; set; }
    }
}
