using LibraryManagementStudio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data
{
    public partial class LibraryDbContext: DbContext
    {
        private string _connectionString = "data source=localhost;initial catalog=LibraryDb;integrated security=true;TrustServerCertificate=True";
        //private string _connectionString = "Server=localhost;Database=LibraryDb;Trusted_Connection=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookBorrow> BookBorrows { get; set; }
        public DbSet<BookStoreCode> BookStoreCodes { get; set; }
        public DbSet<Penalty> Penalties { get; set; }

        public LibraryDbContext(){ }

        public LibraryDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Penalty>()
                .HasKey(x => x.PenaltyId);

            modelBuilder.Entity<BookStoreCode>()
                .HasKey(x => x.BookStoreCodeId);

            RegisterBookModel(modelBuilder);
            RegisterBookBorrowModel(modelBuilder);
            RegisterPublisherModel(modelBuilder);
            RegisterAuthorModel(modelBuilder);
            RegisterWorkerModel(modelBuilder);
            RegisterUserModel(modelBuilder);
            RegisterBookCopyModel(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
