using LibraryManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio;

public partial class LibraryDbContext
{
    private static void RegisterAuthorModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(x => x.AuthorId);

            entity.HasMany(x => x.Books)
                .WithOne(x => x.Author)
                .HasForeignKey(x => x.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}