using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                 .HasKey(c => new { c.BookId, c.UserId, c.DateTime });

            builder
                .HasOne<User>(u => u.User)
                .WithMany(b => b.Orders)
                .HasForeignKey(u => u.UserId);

            builder
                .HasOne<Book>(b => b.Book)
                .WithMany(b => b.Orders)
                .HasForeignKey(b => b.BookId);
        }
    }
}
