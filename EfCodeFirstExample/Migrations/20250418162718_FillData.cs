using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCodeFirstExample.Migrations
{
    /// <inheritdoc />
    public partial class FillData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // INSERT INTO Genres (Title) VALUES (("Fantasy"),("SciFi"))
            migrationBuilder.InsertData(
                table: "Genres",
                columns: ["Title"],
                values: new object[,]
                {
                      {"Fantasy"},
                      {"Science Fiction"},
                      {"Detective"},
                      {"Thriller"},
                      {"Romance"},
                      {"Historical"},
                      {"Horror"},
                      {"Biography"},
                      {"Self-Help"},
                      {"Children's"}
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: ["FirstName", "LastName"],
                values: new object[,]
                {
                    { "Joanne", "Rowling" },
                    { "Stephen", "King" },
                    { "Agatha", "Christie" },
                    { "George", "Orwell" },
                    { "Jane", "Austen" },
                    { "Ernest", "Hemingway" },
                    { "Tolkien", "John" },
                    { "Haruki", "Murakami" },
                    { "Gabriel", "García Márquez" },
                    { "Virginia", "Woolf" }
                }
                );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
