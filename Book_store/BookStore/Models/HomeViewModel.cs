using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class HomeViewModel
    {
        public List<Book> AllBooks { get; set; }
    }
}
