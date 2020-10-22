using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public IList<BookCategory> Categories { get; set; }

    }
}
