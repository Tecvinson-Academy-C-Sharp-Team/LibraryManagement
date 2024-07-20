using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Entity
{
    public abstract class LibraryItem
    {
        public Book? Book { get; set; }
        // DVD
        // Magazine

        //public abstract string GetDetails();
    }
}