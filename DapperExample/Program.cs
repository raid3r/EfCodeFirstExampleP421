// See https://aka.ms/new-console-template for more information
using Dapper;
using DapperExample.Models;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");


var connectionString = "Data Source=SILVERSTONE\\SQLEXPRESS;Initial Catalog=BookShopPV421;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;


using (var connection = new SqlConnection(connectionString))
{
    // Insert book
    connection.Open();
    var sql = "INSERT INTO Books (Title, AuthorId, Price, Quantity) VALUES (@Title, @AuthorId, @Price, @Quantity)";
    connection.Execute(sql, new { Title = "New Book", AuthorId = 1, Price = 19.99, Quantity = 10 });

    var book1 = connection.QueryFirstOrDefault<Book>("SELECT TOP 1 * FROM Books WHERE Title = @Title", new { Title = "New Book" });

    //connection.Open();

    var sql1 = "SELECT b.Title AS Name, a.first_name + ' ' + a.last_name AS Author FROM Books b LEFT JOIN Authors a ON b.AuthorId = a.Id";

    var books = connection.Query<Book>(sql1).ToList();
    foreach (var book in books)
    {
        Console.WriteLine($"Name: {book.Name}, Author: {book.Author}");
    }
}


// Напишіть код, який підключається до бази даних та виводе дані з усіх таблиць,
// з використанням Dapper.
// Додайте можливість вставки нових записів у таблиці. (хоча б в одну таблицю)

