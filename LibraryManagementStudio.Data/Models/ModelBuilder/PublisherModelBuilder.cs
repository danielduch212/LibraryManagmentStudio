using LibraryManagementStudio.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data;

public partial class LibraryDbContext
{
    private static void RegisterPublisherModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(x => x.PublisherId);

            entity.HasMany(x => x.Books)
                .WithOne(x => x.Publisher)
                .HasForeignKey(x => x.PublisherId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}