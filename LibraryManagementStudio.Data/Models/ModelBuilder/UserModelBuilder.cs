using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data;

public partial class LibraryDbContext
{
    private static void RegisterUserModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Data.Models.User>(entity =>
        {
            entity.HasKey(x => x.UserId);

            entity.HasMany(x => x.BookBorrows)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}