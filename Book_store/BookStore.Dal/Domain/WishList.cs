using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class WishList
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
