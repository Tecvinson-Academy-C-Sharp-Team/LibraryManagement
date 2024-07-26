using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public class LibraryItem
    {
        public Book? Book { get; set; }
        public DVD DVD { get; set; }
        public Magazine Magazine { get; set; }

        // public abstract string GetDetails();
    }
}