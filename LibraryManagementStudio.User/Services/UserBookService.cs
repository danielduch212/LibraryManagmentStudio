using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.User.Dtos.Book;
using LibraryManagementStudio.User.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User.Services;

public class UserBookService : IUserBookService
{
    private readonly LibraryDbContext _dbContext;
    
    public UserBookService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<BookDto> GetBooks()
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
            BookCopiesCount = x.BookCopies.Count(y => y.IsAvailable)
        });
        
        return books.ToList();
    }
    
    public IEnumerable<BookDto> GetBooks(string title)
    {
        var query = _dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.Publisher)
            .Include(x => x.BookCopies);

        var books = query.Where(x => x.Title.ToLower().Contains(title.ToLower())).Select(x => new BookDto()
        {
            BookId = x.BookId,
            Title = x.Title,
            Description = x.Description,
            AuthorName = x.Author.Name,
            PublisherName = x.Publisher.Name,
            PublishDate = x.PublishDate,
            Category = x.Category,
            BookCopiesCount = x.BookCopies.Count(y => y.IsAvailable)
        });
        
        return books.ToList();
    }

    // public BookDto? GetBook(int bookId)
    // {
    //     var query = _dbContext.Books
    //         .Include(x => x.Author)
    //         .Include(x => x.Publisher)
    //         .Include(x => x.BookCopies);
    //
    //     var book = query.FirstOrDefault(x => x.BookId == bookId);
    //     
    //     if (book == null)
    //     {
    //         return null;
    //     }
    //     
    //     var bookDto = new BookDto()
    //     {
    //         BookId = book.BookId,
    //         Title = book.Title,
    //         Description = book.Description,
    //         AuthorName = book.Author.Name,
    //         PublisherName = book.Publisher.Name,
    //         PublishDate = book.PublishDate,
    //         Category = book.Category,
    //         BookCopiesCount = book.BookCopies.Count
    //     };
    //     
    //     return bookDto;
    // }
}