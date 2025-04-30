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
    private readonly AuthorPrinter _authorPrinter;

    public MyApp(BookStoreContext context, AuthorPrinter authorPrinter)
    {
        _context = context;
        _authorPrinter = authorPrinter;
    }

    private void ShowMenu()
    {
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Show Books");
        Console.WriteLine("3. Add Author");
        Console.WriteLine("4. Show Authors");
        Console.WriteLine("5. Add Genre");
        Console.WriteLine("6. Show Genres");
        Console.WriteLine("7. Add Book Sale");
        Console.WriteLine("8. Show Book Sales");
        Console.WriteLine("9. Exit");
    }

    private void ShowAuthors()
    {
        _authorPrinter.Print(_context.Authors.ToList());
    }   

    public void Run()
    {
        while (true)
        {

            ShowMenu();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "4":
                    ShowAuthors();
                    break;  
                case "9":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }
    }
}
