using LibraryManagement.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DVD> Dvds { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=library.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //this.CreateTables();
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LibraryItem>()
                .HasMany(e => e.Books)
                .WithOne(e => e.LibraryItem)
                .HasForeignKey(e => e.LibraryItemId)
                .IsRequired();

            modelBuilder.Entity<LibraryItem>()
                .HasMany(e => e.Dvds)
                .WithOne(e => e.LibraryItem)
                .HasForeignKey(e => e.LibraryItemId)
                .IsRequired();

            modelBuilder.Entity<LibraryItem>()
                .HasMany(e => e.Magazines)
                .WithOne(e => e.LibraryItem)
                .HasForeignKey(e => e.LibraryItemId)
                .IsRequired();
        }

        public static void Seed(LibraryContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Books.Add(new Book { Title = "C# Programming", Author = "Author Name" });
            context.SaveChanges();
        }
    }
}