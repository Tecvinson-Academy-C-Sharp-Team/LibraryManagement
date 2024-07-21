using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class LibraryItem
    {
        public List<Book>? Books { get; set; }
        public DVD? Dvd { get; set; }
        public Magazine? Magazine { get; set; }

        // public abstract string GetDetails();
    }
}