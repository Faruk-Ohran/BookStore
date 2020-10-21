using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Context
{
    class BookStoreDbContext
    {
        public List<User> Users { get; set; }
        public List<Book> Books { get; set; }
    }
}
