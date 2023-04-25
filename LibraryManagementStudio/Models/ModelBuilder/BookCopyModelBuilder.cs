using LibraryManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio;

public partial class LibraryDbContext
{
    private static void RegisterBookCopyModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookCopy>(entity =>
        {
            entity.HasKey(x => x.BookCopyId);

            entity.HasOne(x => x.BookBorrow)
                .WithOne(x => x.BookCopy)
                .HasForeignKey<BookBorrow>(x => x.BookCopyId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}