using LibraryManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio;

public partial class LibraryDbContext
{
    private static void RegisterBookBorrowModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookBorrow>(entity =>
        {
            entity.HasKey(x => x.BookBorrowId);

            entity.HasOne(x => x.Penalty)
                .WithOne(x => x.BookBorrow)
                .HasForeignKey<Penalty>(x => x.BookBorrowId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasMany(x => x.BookStoreCodes)
                .WithOne(x => x.BookBorrow)
                .HasForeignKey(x => x.BookBorrowId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}