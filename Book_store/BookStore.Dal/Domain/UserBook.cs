using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Domain
{
    public class UserBook:BaseEntity
    {
        public bool isWishList { get; set; }
        public bool isCart { get; set; }
        public bool isOrdered { get; set; }
        public ICollection<Book> Books { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
