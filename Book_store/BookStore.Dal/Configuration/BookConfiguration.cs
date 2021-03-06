﻿using BookStore.Domain;
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
                .HasMany(ub => ub.Books)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookUserId);

            builder
                .HasMany(o => o.Orders)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId);

            builder
                .HasData(
                new List<Book>{

                new Book
                {
                    Id=1,
                    Author="naziv_autora_1",
                    Name="naziv_knjige_1",
                    Price=10,
                    CreatedBy="faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc),
                },
                new Book
                {
                    Id = 2,
                    Author = "naziv_autora_2",
                    Name = "naziv_knjige_2",
                    Price = 20,
                    CreatedBy = "faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc),
                },
                new Book
                {
                    Id = 3,
                    Author = "naziv_autora_3",
                    Name = "naziv_knjige_3",
                    Price = 15,
                    CreatedBy = "faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc),
                },
                new Book
                {
                    Id = 4,
                    Author = "naziv_autora_4",
                    Name = "naziv_knjige_4",
                    Price = 25,
                    CreatedBy = "faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc),
                } 
                });
        }
    }
}
