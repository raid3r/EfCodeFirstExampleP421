
using EfCodeFirstExample.Models;

Console.WriteLine("EntityFramework Code First");


using var db = new BookStoreContext();
db.Authors.ToList().ForEach(a => Console.WriteLine($"{a.Id} {a.FirstName} {a.LastName}"));



/**
 * Магазин книг
 *  
 *  + Книга  * --- 1 Автор
 *  
 *  + Книга  * --- 1  ЖанрКниги  1 --- * Жанр
 *  
 *  + Продаж книги * --- 1 Книга
 *  
 *  
 *  1. Визначити сутності предметної галузі
 *  2. Визначити зв'язки між сутностями
 *  3. Визначити атрибути сутностей
 *  4. Реалізувати класи сутностей
 *  5. Реалізувати контекст бази даних
 *  6. Додати атрибути (для уточнення того як генерувати таблиці та колонки) до класів сутностей
 *  7. Створення міграції
 *  
 *  + Книга
 *  - Id
 *  - Назва
 *  - Автор
 *  - Жанри
 *  - Ціна
 *  - Кількість
 *  
 *  + Автор
 *  - Id
 *  - Призвище
 *  - Ім'я
 *  
 *  + Жанр
 *  - Id
 *  - Назва
 *  
 *  Продаж книги
 *  - Id
 *  - Книга
 *  - Дата
 *  - Кількість
 *  - Ціна
 *  - Сума
 *  
 *  Міграції
 *  
 *               0        ---- міграція UP------->      1                        ----- міграція -----> 2      ---------------- 3
 *                            <---------DOWN----------                             <------------------        <-------------   TestTables
 *                            class                                                 class
 *          стан бази даних -------------------> стан бази даних 1                    -----> стан бази даних 2
 *  
 *          немає бази даних ------------------> є база даних  ---> ---------------> Додано поле опис до таблиці Books
 *          немає жодної таблиці --------------> є таблиці Authors, Books, Genres,   
                                           *          BookSales
 *                                                 з відповідними колонками
 *                                                 
 *                                   виконати SQL скрипти                               виконати SQL скрипти
  *                                   - CREATE DATABASE ....                       ALTER TABLE Books ADD Description NVARCHAR(500) NULL
 *                                   - CREATE TABLE Authors....                     
 *                                   - CREATE TABLE Books....                      ALTER TABLE Books DROP COLUMN Description
 *                                   - CREATE TABLE Genres....
 *                                   - CREATE TABLE BookSales....
 *  
 *  
 *  
 *  add-migration MigrationName
 *  update-database
 *  
 *  
 *  
 *  
 *  
 */

