﻿using BookStore.Dal.Domain;
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
        public ICollection<UserBook> Books { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
