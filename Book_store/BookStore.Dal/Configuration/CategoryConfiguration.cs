using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.CategoryName)
                .IsRequired();

            builder
                .HasData(

                new Category
                {
                    Id=1,
                    CategoryName="Poezija",
                    CreatedBy="faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc)
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Drama",
                    CreatedBy = "faruk",
                    CreatedAt = new DateTime(2020, 10, 23, 10, 00, 00, DateTimeKind.Utc)
                });
        }
    }
}
