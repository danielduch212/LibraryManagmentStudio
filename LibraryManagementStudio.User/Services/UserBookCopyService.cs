using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.User.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User.Services;

public class UserBookCopyService : IUserBookCopyService
{
    private readonly LibraryDbContext _dbContext;

    public UserBookCopyService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public BookCopy? GetAvailableBookCopy(int bookId)
    {
        var query = _dbContext.BookCopies
            .Include(x => x.Book);

        query.ThenInclude(y => y.Author);
        query.ThenInclude(y => y.Publisher);

        var bookCopy = query.FirstOrDefault(x => x.BookId == bookId && x.IsAvailable);
        
        if (bookCopy == null)
        {
            return null;
        }
        
        return bookCopy;
    }
}