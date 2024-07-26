using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Data
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<DVD> Dvds { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Borrows { get; set; }
    }
}