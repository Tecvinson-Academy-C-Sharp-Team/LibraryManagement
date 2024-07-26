using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class Loan
    {
        public long MemberID { get; set; }
        public long LoanID { get; set; }
        public long BookID { get; set; }
        public long DVDID { get; set; }
        public long MagazineID { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
