using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagement.BusinessLogic.Service
{
    public class LibraryService : ILibraryService
    {
        private List<LibraryItem> _libraryItems = new List<LibraryItem>();
        private readonly LibraryContext _libraryContext;

        public LibraryService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public delegate void Notify(string message);

        public event Notify? OnBookAdded;

        public event Notify? OnBookRemoved;

        public event Notify? OnBorrowLibraryItem;

        public event Notify? OnReturnLibraryItem;

        // delegate use
        private Notify notification = new Notify(OnNewBookAdded);

        public static void OnNewBookAdded(string title)
        {
            // some things happens here ...

            // raise the book added event here ...
            Console.WriteLine($"A book with title: {title} was added to our library!");
        }

        public async Task<Book> AddBookToLibrary(Book book)
        {
            _libraryContext.Books.Add(book);

            string msg = $"A book with title: {book.Title} was added to our library!";
            OnBookAdded?.Invoke(msg);

            return book;
        }

        public async Task<Book> UpdateBook(Book book)
        {
            // LINQ: Language integrated query
            // C#: var existingBook = _libraryContext.Books.Where(b => b.Id.Equals(book.Id)).SingleOrDefault();
            // SQL: SELECT * FROM BOOK WHERE Id = book.Id;

            var existingBook = _libraryContext.Books.Where(b => b.Id.Equals(book.Id)).SingleOrDefault();

            var b = _libraryContext.Books.Update(book);
            return book;
        }

        public async Task<Book> DeleteBook(long Id)
        {
            var existingBook = _libraryContext.Books.Where(b => b.Id.Equals(Id)).SingleOrDefault();
            string msg = $"A book with title: {existingBook.Title} is deleted from to our library!";
            OnBookRemoved?.Invoke(msg);

            _libraryContext.Books.Remove(existingBook);

            return existingBook;
        }

        public async Task<Book> CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<DVD> CreateDVD(DVD dvd)
        {
            throw new NotImplementedException();
        }

        public async Task<DVD> UpdateDVD(DVD dvd)
        {
            throw new NotImplementedException();
        }

        public async Task<DVD> DeleteDVD(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<DVD> AddDVDToLibrary(DVD dvd)
        {
            throw new NotImplementedException();
        }

        public async Task<Magazine> CreateMagazine(Magazine magazine)
        {
            throw new NotImplementedException();
        }

        public async Task<Magazine> UpdateMagazine(Magazine magazine)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteMagazine(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Magazine> AddMagazineToLibrary(Magazine magazine)
        {
            throw new NotImplementedException();
        }

        public async Task<LibraryItem> GetLibraryItem(long Id)
        {
            throw new NotImplementedException();
        }

        public async Task<LibraryItem> GetLibraryItem(string Name)
        {
            throw new NotImplementedException();
        }

        public async Task<LibraryItem> BorrowLibraryItem(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<LibraryItem> ReturnLibraryItem(LibraryItem libraryItem)
        {
            throw new NotImplementedException();
        }
    }
}