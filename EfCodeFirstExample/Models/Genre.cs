using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample.Models;

public class Genre
{
    public int Id { get; set; } // Id жанру

    [MaxLength(50)]
    public string Title { get; set; } = null!; // Назва жанру    

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
