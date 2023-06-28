using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementAPI.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace LibraryManagementAPI.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração do relacionamento entre Livro e Autor
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books)
                .UsingEntity(j => j.ToTable("BookAuthor"));

            // Configuração do relacionamento entre Usuario e Livro
            modelBuilder.Entity<User>()
                .HasMany(u => u.BorrowedBooks)
                .WithMany()
                .UsingEntity(j => j.ToTable("UserBook"));
        }
    }
}