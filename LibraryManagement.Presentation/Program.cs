using LibraryManagement.BusinessLogic.Service;
using LibraryManagement.Data.Data;
using LibraryManagement.Data.Entity;
using LibraryManagement.Data.Service;
using System.Threading.Channels;

namespace LibraryManagement.Presentation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            ILibraryService libraryService = new LibraryService(new());

            Book book = new Book()
            {
                Id = 1,
                Title = "Things fall apart"
            };

            // create new member entity

            {
                
            }
        }
    }
}