using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Cart:BaseEntity
    {
        public Cart(string createdBy):base(createdBy)
        {

        }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
