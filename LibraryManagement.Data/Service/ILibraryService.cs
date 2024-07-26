using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;

namespace LibraryManagement.Data.Service
{
    public interface ILibraryService
    {
        Task<Book> AddBookToLibrary(Book book);

        Task<Book> UpdateBook(Book book);

        Task<Book> DeleteBook(long Id);

        Task<Book> CreateBook(Book book);

        Task<DVD> CreateDVD(DVD dvd);

        Task<DVD> UpdateDVD(DVD dvd);

        Task<DVD> DeleteDVD(long Id);

        Task<DVD> AddDVDToLibrary(DVD dvd);

        Task<Magazine> CreateMagazine(Magazine magazine);

        Task<Magazine> UpdateMagazine(Magazine magazine);

        Task DeleteMagazine(long Id);

        Task<Magazine> AddMagazineToLibrary(Magazine magazine);

        Task<LibraryItem> GetLibraryItem(long Id);

        Task<LibraryItem> GetLibraryItem(string Name);

        Task<LibraryItem> BorrowLibraryItem(string name);

        Task<LibraryItem> ReturnLibraryItem(LibraryItem libraryItem);
    }
}