using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LibraryContext>
    {
        public LibraryContext CreateDbContext(string[] args)
        {
            // Configure the DbContextOptionsBuilder
            var optionsBuilder = new DbContextOptionsBuilder<LibraryContext>();

            // Use SQLite and point to the database file
            optionsBuilder.UseSqlite("Data Source=library.db");

            return new LibraryContext(optionsBuilder.Options);
        }
    }
}