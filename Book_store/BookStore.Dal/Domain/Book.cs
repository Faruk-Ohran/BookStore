﻿using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public IList<BookCategory> Categories { get; set; }
        public ICollection<UserBook> Books { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
