using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        public List<LibraryItem> BorrowedItems { get; set; } = new List<LibraryItem>();
    }
}