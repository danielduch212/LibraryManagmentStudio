using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Parcel;

public class ParcelService
{
    private readonly LibraryDbContext _dbContext;

    public ParcelService()
    {
        _dbContext = new LibraryDbContext();
    }

    public string? AcceptBookBorrow(string code)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.BookStoreCodes)
            .Include(x => x.BookCopy)
            .ThenInclude(x => x.Book)
            .FirstOrDefault(x => x.BookStoreCodes.Any(y => y.Code == code));

        if (bookBorrow == null)
            return null;

        bookBorrow.StartDate = DateTime.Now;
        bookBorrow.EndDate = DateTime.Now.AddDays(14);
        bookBorrow.Status = BorrowedBookStatus.Received;
        _dbContext.SaveChanges();
        
        return bookBorrow.BookCopy.Book.Title;
    }
    
    public string? AcceptBookReturn(string code)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.BookStoreCodes)
            .Include(x => x.BookCopy)
            .ThenInclude(x => x.Book)
            .FirstOrDefault(x => x.BookStoreCodes.Any(y => y.Code == code));

        if (bookBorrow == null)
            return null;
        
        bookBorrow.Status = BorrowedBookStatus.ReadyForReturn;
        _dbContext.SaveChanges();
        
        return bookBorrow.BookCopy.Book.Title;
    }
}