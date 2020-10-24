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
        }
    }
}
