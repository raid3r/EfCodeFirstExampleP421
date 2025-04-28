using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample.Models;

/*
 CREATE TABLE Books (
     Id INT PRIMARY KEY IDENTITY(1,1),
     Title NVARCHAR(500) NOT NULL,
     Price DECIMAL(18,2) NOT NULL,
     Quantity INT NOT NULL,
     AuthorId INT FOREIGN KEY REFERENCES Authors(Id)
  */
public class Book
{
    public int Id { get; set; } // Id книги

    [MaxLength(500)]
    public string Title { get; set; } = null!; // Назва книги

    [MaxLength(5000)] // ALTER TABLE Books ADD COLUMN Description NVARCHAR(500) NULL;
    public string? Description { get; set; }

    public decimal Price { get; set; } // Ціна книги

    public int Quantity { get; set; } // Кількість книг на складі

    public virtual Author Author { get; set; } = null!;

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();

    public virtual ICollection<BookSale> BookSales { get; set; } = new List<BookSale>();
}
