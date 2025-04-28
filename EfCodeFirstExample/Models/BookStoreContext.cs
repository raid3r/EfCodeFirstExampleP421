using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample.Models;

public class BookStoreContext : DbContext
{
    public BookStoreContext()
    {
    }

    public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; } = null!;
    public virtual DbSet<Author> Authors { get; set; } = null!;
    public virtual DbSet<Genre> Genres { get; set; } = null!;
    public virtual DbSet<BookSale> BookSales { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=SILVERSTONE\\SQLEXPRESS;Initial Catalog=BookShopPV421;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Fluent API configuration

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Author>()
            .ToTable("authors")
            .HasKey(x => x.Id);

        modelBuilder
            .Entity<Author>()
            .Property(a => a.Id)
            .HasColumnName("id")
            .HasColumnType("int")
            .UseIdentityColumn(1, 1) // IDENTITY(1,1) in SQL Server
            ;

        modelBuilder
            .Entity<Author>()
            .Property(a => a.FirstName)
            .HasColumnName("first_name")
            .IsRequired(true)
            .HasMaxLength(70)
            .HasColumnType("nvarchar(70)");

        
        modelBuilder
            .Entity<Author>()
            .Property(a => a.LastName)
            .HasColumnName("last_name")
            .IsRequired(true)
            .HasMaxLength(70)
            .HasColumnType("nvarchar(70)");






    }
}

