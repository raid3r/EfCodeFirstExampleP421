using EfCodeFirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstExample;

public class AuthorPrinter
{
    public void Print(IEnumerable<Author> authors)
    {
        // Table header
        Console.WriteLine("ID\tFirst Name\tLast Name");
        foreach (var author in authors)
        {
            Console.WriteLine($"{author.Id}\t{author.FirstName}\t{author.LastName}");
        }
    }
}
