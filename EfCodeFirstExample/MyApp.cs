using EfCodeFirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample;

public class MyApp
{
    private readonly BookStoreContext _context;

    public MyApp(BookStoreContext context)
    {
        _context = context;
    }

    public void Run()
    {
        // Example usage of the context
        var authors = _context.Authors.ToList();
        foreach (var author in authors)
        {
            Console.WriteLine($"{author.FirstName} {author.LastName}");
        }
    }
}
