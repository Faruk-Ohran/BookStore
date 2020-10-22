using BookStore.Dal.Configuration;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Context
{
    public class BookStoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Server=.;Initial Catalog=BookStore;Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.Entity<Cart>().HasKey(sc => new { sc.UserId, sc.BookId });
            modelBuilder.Entity<WishList>().HasKey(sc => new { sc.UserId, sc.BookId });
            modelBuilder.Entity<Order>().HasKey(sc => new { sc.UserId, sc.BookId });
            modelBuilder.Entity<BookCategory>().HasKey(sc => new { sc.BookId, sc.CategoryId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
