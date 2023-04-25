using LibraryManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio;

public partial class LibraryDbContext
{
    private static void RegisterWorkerModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(x => x.WorkerId);

            entity.HasMany(x => x.Books)
                .WithOne(x => x.Worker)
                .HasForeignKey(x => x.WorkerId)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasMany(x => x.Users)
                .WithOne(x => x.Worker)
                .HasForeignKey(x => x.WorkerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            
            entity.HasMany(x => x.BookBorrows)
                .WithOne(x => x.Worker)
                .HasForeignKey(x => x.WorkerId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}