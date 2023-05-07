using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.BookBorrow;
using LibraryManagementStudio.Worker.Services.Intrefaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Worker.Services;

public class WorkerBookBorrowService : IWorkerBookBorrowService
{
    private readonly LibraryDbContext _dbContext;
    private readonly IEmailService _emailService;

    public WorkerBookBorrowService(LibraryDbContext dbContext, IEmailService emailService)
    {
        _dbContext = dbContext;
        _emailService = emailService;
    }

    public List<BookBorrowDto> GetBorrowedBooks()
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.IsActive && x.Status == BorrowedBookStatus.Requested)
            .Select(x => new BookBorrowDto()
            {
                BookBorrowId = x.BookBorrowId,
                BookTitle = x.BookCopy.Book.Title,
                BookCopyId = x.BookCopyId,
                UserEmailAddress = x.User.EmailAddress,
            });
        
        var bookBorrows = query.ToList();
        
        return bookBorrows;
    }
    
    public List<BookBorrowDto> GetReturnedBooks()
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.IsActive && x.Status == BorrowedBookStatus.ReadyForReturn)
            .Select(x => new BookBorrowDto()
            {
                BookBorrowId = x.BookBorrowId,
                BookTitle = x.BookCopy.Book.Title,
                BookCopyId = x.BookCopyId,
                UserEmailAddress = x.User.EmailAddress,
            });
        
        var bookBorrows = query.ToList();
        
        return bookBorrows;
    }
    
    public void AcceptBookBorrow(int bookBorrowId)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.User)
            .Include(x => x.BookStoreCodes)
            .Include(x => x.BookCopy)
            .ThenInclude(x => x.Book)
            .FirstOrDefault(x => x.BookBorrowId == bookBorrowId);
        
        if (bookBorrow is null)
            return;
        
        bookBorrow.Status = BorrowedBookStatus.ReadyForPickup;
        _dbContext.SaveChanges();
        
        _emailService.SendPickupCodeMessage(bookBorrow.User.EmailAddress, bookBorrow.BookStoreCodes.First(x => x.CodeType == CodeType.odbior).Code, bookBorrow.BookCopy.Book.Title);
    }

    public void AcceptBookReturn(int bookBorrowId)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.BookCopy)
            .FirstOrDefault(x => x.BookBorrowId == bookBorrowId);
        
        if (bookBorrow is null)
            return;
        
        bookBorrow.Status = BorrowedBookStatus.Returned;
        bookBorrow.BookCopy.IsAvailable = true;
        bookBorrow.IsActive = false;
        _dbContext.SaveChanges();
    }
}