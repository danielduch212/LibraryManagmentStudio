using LibraryManagementStudio.Dtos;
using LibraryManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Services;

public class BookService
{
    private readonly LibraryDbContext _dbContext;
    
    public BookService()
    {
        _dbContext = new LibraryDbContext();
    }
    
    public async Task<IEnumerable<BookDto>> GetBooksAsync()
    {
        var query = _dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.Publisher)
            .Include(x => x.BookCopies);

        var books = query.Select(x => new BookDto()
        {
            BookId = x.BookId,
            Title = x.Title,
            Description = x.Description,
            AuthorName = x.Author.Name,
            PublisherName = x.Publisher.Name,
            PublishDate = x.PublishDate,
            Category = x.Category,
            BookCopiesCount = x.BookCopies.Count
        });
        
        return await books.ToListAsync();
    }
}