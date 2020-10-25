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
                .HasOne(b => b.Book)
                .WithMany(ub => ub.Books)
                .HasForeignKey(b => b.BookUserId);

            builder
                .HasOne(u => u.User)
                .WithMany(ub => ub.Books)
                .HasForeignKey(u => u.UserBookId);

            builder
                .HasData(new List<UserBook>
                {
                    new UserBook
                    { Id=1, UserBookId=1, BookUserId=1, isCart=true },
                    new UserBook
                    { Id=2, UserBookId=1, BookUserId=3, isCart=false },
                    new UserBook
                    { Id=3, UserBookId=1, BookUserId=4, isCart=true },
                    new UserBook
                    { Id=4, UserBookId=2, BookUserId=4, isCart=true },
                    new UserBook
                    { Id=5, UserBookId=2, BookUserId=3, isCart=true },
                    new UserBook
                    { Id=6, UserBookId=2, BookUserId=2, isCart=false }
                });
        }
    }
}
