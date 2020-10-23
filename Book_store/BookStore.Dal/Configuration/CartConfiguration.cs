using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class CartConfiguration:IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder
                .HasKey(c => new { c.BookId, c.UserId });

            builder
                .HasOne<User>(u => u.User)
                .WithMany(b => b.Carts)
                .HasForeignKey(u => u.UserId);

            builder
                .HasOne<Book>(b => b.Book)
                .WithMany(b => b.Carts)
                .HasForeignKey(b => b.BookId);
        }
    }
}
