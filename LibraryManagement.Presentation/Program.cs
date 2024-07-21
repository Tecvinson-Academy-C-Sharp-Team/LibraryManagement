using LibraryManagement.BusinessLogic.Service;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;

Console.WriteLine("Welcome to C# group Library Management System!");
Console.WriteLine("How can I be of service?");

Book book = new Book()
{
    Id = 1,
    Title = "Things fall apart"
};

ILibraryService libraryService = new LibraryService(new());
libraryService.AddBookToLibrary(book);