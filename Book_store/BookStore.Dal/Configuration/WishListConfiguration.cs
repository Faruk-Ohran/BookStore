using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    class WishListConfiguration: IEntityTypeConfiguration<WishList>
    {
        public void Configure(EntityTypeBuilder<WishList> builder)
        {
            builder
                 .HasKey(c => new { c.BookId, c.UserId });

            builder
                .HasOne<User>(u => u.User)
                .WithMany(b => b.WishLists)
                .HasForeignKey(u => u.UserId);

            builder
                .HasOne<Book>(b => b.Book)
                .WithMany(b => b.WishLists)
                .HasForeignKey(b => b.BookId);
        }
    }
}
