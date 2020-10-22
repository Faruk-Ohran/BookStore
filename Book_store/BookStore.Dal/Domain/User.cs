using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class User:BaseEntity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public IList<Cart> Carts { get; set; }
        public IList<WishList> wishLists { get; set; }
        public IList<Order> Orders { get; set; }

    }
}
