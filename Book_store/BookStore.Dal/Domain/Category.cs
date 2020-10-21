using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Category:BaseEntity
    {
        public Category(string createdBy):base(createdBy)
        {

        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
