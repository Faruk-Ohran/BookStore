using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.FirstName)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .IsRequired();

            builder
                .HasMany(ub => ub.Books)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId);

            builder
                .HasData(new List<User>
                {
                    new User
                    {
                        Id=1,
                        FirstName="Faruk",
                        LastName="Ohran",
                        CreatedAt=new DateTime(2020, 10, 22, 10, 07, 00, DateTimeKind.Utc),
                        CreatedBy="faruk",
                        Email="ohran.faruk@hotmail.com",
                        Password="123456"
                    },
                    new User
                    {
                        Id=2,
                        FirstName="Jasir",
                        LastName="Buric",
                        CreatedAt=new DateTime(2020, 10, 22, 10, 07, 00, DateTimeKind.Utc),
                        CreatedBy="jasir",
                        Email="jasir.buric@hotmail.com",
                        Password="123456"
                    },
                    new User
                    {
                        Id=3,
                        FirstName="Muhamed",
                        LastName="Halkic",
                        CreatedAt=new DateTime(2020, 10, 22, 10, 07, 00, DateTimeKind.Utc),
                        CreatedBy="muhamed",
                        Email="muhamed.halkic@hotmail.com",
                        Password="123456"
                    },
                    new User
                    {
                        Id=4,
                        FirstName="Mirzad",
                        LastName="Varupa",
                        CreatedAt=new DateTime(2020, 10, 22, 10, 07, 00, DateTimeKind.Utc),
                        CreatedBy="mirzad",
                        Email="mirzad.varupa@hotmail.com",
                        Password="123456"
                    }
                });
        }
    }
}
