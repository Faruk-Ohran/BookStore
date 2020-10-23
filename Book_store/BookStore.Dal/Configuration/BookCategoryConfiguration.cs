using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder
                .HasKey(c => new { c.BookId, c.CategoryId });

            builder
                .HasOne<Category>(u => u.Category)
                .WithMany(b => b.Categories)
                .HasForeignKey(u => u.BookId);

            builder
                .HasOne<Book>(b => b.Book)
                .WithMany(b => b.Categories)
                .HasForeignKey(b => b.BookId);
        }
    }
}
