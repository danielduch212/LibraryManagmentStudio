using LibraryManagementStudio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data;

public partial class LibraryDbContext
{
    private static void RegisterBookCopyModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookCopy>(entity =>
        {
            entity.HasKey(x => x.BookCopyId);

            entity.HasMany(x => x.BookBorrows)
                .WithOne(x => x.BookCopy)
                .HasForeignKey(x => x.BookCopyId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}