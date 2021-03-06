﻿using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Domain
{
    public class UserBook:BaseEntity
    {
        public bool isWishList { get; set; }
        public bool isCart { get; set; }
        public int UserBookId { get; set; }
        public User User { get; set; }
        public int BookUserId { get; set; }
        public Book Book { get; set; }
    }
}
