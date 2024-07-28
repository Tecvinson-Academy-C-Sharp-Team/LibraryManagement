using LibraryManagement.Data;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

Console.WriteLine("Welcome to C# group Library Management System!");

// Configure services
var serviceProvider = new ServiceCollection()
    .AddDbContext<LibraryContext>(options =>
        options.UseSqlite("Data Source=library.db"))
    .AddScoped<IRepository<Book>, BookRepository>()
    .BuildServiceProvider();

var bookRepo = serviceProvider.GetService<IRepository<Book>>();

var book = new Book { Title = "C# Programming", Author = "Author Name", ISBN = "0111C#89" };
await bookRepo.AddAsync(book);
Console.WriteLine($"Book added: {book.Title} by {book.Author}");

var books = await bookRepo.GetAllAsync();
foreach (var b in books)
{
    Console.WriteLine($"Book: {b.Title} by {b.Author}");
}