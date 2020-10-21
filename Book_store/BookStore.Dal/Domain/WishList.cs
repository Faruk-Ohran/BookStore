using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class WishList:BaseEntity
    {
        public WishList(string createdBy):base(createdBy)
        {

        }
        public int UserID { get; set; }
        public User User { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
