using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class LibraryItem
    {
        public List<Member> Members { get; set; }
        public List<Loan> Loans { get; set; }
        public List<Book?> Books { get; set; }
        public List<DVD?> Dvds { get; set; }
        public List<Magazine?> Magazines { get; set; }

        // public abstract string GetDetails();
    }
}