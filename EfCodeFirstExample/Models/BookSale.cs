using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample.Models;

public class BookSale
{
    public int Id { get; set; } // Id продажу книги

    public DateTime Date { get; set; } // Дата продажу книги

    public int Quantity { get; set; } // Кількість проданих книг

    public decimal Price { get; set; } // Ціна книги на момент продажу

    public decimal Sum { get; set; } // Сума продажу книги

    public virtual Book Book { get; set; } = null!;
}
