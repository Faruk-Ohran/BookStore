using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class BookConfiguration:BaseEntityConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .Property(p => p.Author)
                .IsRequired();

            builder
                .Property(p => p.Price)
                .IsRequired();

            builder
               .HasOne(p=>p.User)
               .WithMany(p=>p.Carts)
               .HasForeignKey(p=>p.UserId);
        }
    }
}
