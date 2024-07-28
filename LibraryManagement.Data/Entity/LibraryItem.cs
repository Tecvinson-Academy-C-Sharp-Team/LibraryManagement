using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class LibraryItem
    {
        public long BookId { get; set; }
        public Book Book { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long DvdId { get; set; }
        public DVD Dvd { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}