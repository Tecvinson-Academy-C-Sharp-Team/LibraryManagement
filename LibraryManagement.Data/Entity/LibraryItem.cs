using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class LibraryItem : BaseEntity
    {
        public long BookId { get; set; }
        public List<Book> Books { get; set; }

        public long DvdId { get; set; }
        public List<DVD> Dvds { get; set; }

        public long MagazineId { get; set; }
        public List<Magazine> Magazines { get; set; }

        public DateTime? BorrowedDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public override string GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}