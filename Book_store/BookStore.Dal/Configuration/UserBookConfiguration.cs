using BookStore.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    class UserBookConfiguration:BaseEntityConfiguration<UserBook>
    {
        public override void Configure(EntityTypeBuilder<UserBook> builder)
        {
            base.Configure(builder);

            builder
                .HasMany(b => b.Books)
                .WithOne(ub => ub.UserBook)
                .HasForeignKey(ub => ub.UserBookId);

            builder
                .HasOne(u => u.User)
                .WithMany(ub => ub.Books)
                .HasForeignKey(u => u.UserId);

            builder
                .HasData(new List<UserBook>
                {
                    new UserBook
                    { Id=1, UserId=1, isCart=true },
                    new UserBook
                    { Id=2, UserId=1, isCart=false },
                    new UserBook
                    { Id=3, UserId=1, isCart=true },
                    new UserBook
                    { Id=4, UserId=2, isCart=true },
                    new UserBook
                    { Id=5, UserId=2, isCart=true },
                    new UserBook
                    { Id=6, UserId=2, isCart=false }
                });
        }
    }
}
