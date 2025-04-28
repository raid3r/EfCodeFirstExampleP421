using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample.Models;

public class Author
{
    public int Id { get; set; } // Id автора

    public string FirstName { get; set; } = null!; // Ім'я автора


    public string LastName { get; set; } = null!; // Призвище автора
    
    //public int? BirthYear { get; set; } // Рік народження автора

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
