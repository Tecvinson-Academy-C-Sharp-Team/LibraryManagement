using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;

namespace LibraryManagement.BusinessLogic.Service
{
    public class LibraryService : ILibraryService
    {
        public async Task<Book> AddBookToLibrary(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<Book> DeleteBook(long Id)
        {
            throw new NotImplementedException();
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