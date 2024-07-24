using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
    {
    public class Loan {
        public long borrowId { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime returnDate { get; set; }
        public long itemID { get; set; }
        }
    }
