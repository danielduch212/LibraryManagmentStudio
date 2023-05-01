using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.BookCopy;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User.Services;

public class UserBookCopyService
{
    private readonly LibraryDbContext _dbContext;

    public UserBookCopyService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public BookCopyDto? GetAvailableBookCopy(int bookId)
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
        
        var bookCopyDto = new BookCopyDto()
        {
            BookCopyId = bookCopy.BookCopyId,
            Title = bookCopy.Book.Title,
            Description = bookCopy.Book.Description,
            AuthorName = bookCopy.Book.Author.Name,
            PublisherName = bookCopy.Book.Publisher.Name,
            PublishDate = bookCopy.Book.PublishDate,
            Category = bookCopy.Book.Category
        };
        
        return bookCopyDto;
    }
}