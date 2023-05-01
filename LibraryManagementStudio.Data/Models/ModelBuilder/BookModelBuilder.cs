using LibraryManagementStudio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data;

public partial class LibraryDbContext
{
    private static void RegisterBookModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(x => x.BookId);

            entity.HasMany(x => x.BookCopies)
                .WithOne(x => x.Book)
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}