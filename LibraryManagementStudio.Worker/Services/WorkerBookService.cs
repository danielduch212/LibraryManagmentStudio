using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Dtos.Book;
using LibraryManagementStudio.Worker.Services.Intrefaces;

namespace LibraryManagementStudio.Worker.Services;

public class WorkerBookService : IWorkerBookService
{
    private readonly LibraryDbContext _dbContext;

    public WorkerBookService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public bool CreateBook(CreateBookDto bookDto)
    {
        var author = _dbContext.Authors.FirstOrDefault(x => x.AuthorId == bookDto.AuthorId);
        var publisher = _dbContext.Publishers.FirstOrDefault(x => x.PublisherId == bookDto.PublisherId);

        if (author == null || publisher == null)
        {
            return false;
        }

        var book = new Book()
        {
            Title = bookDto.Title,
            Description = bookDto.Description,
            AuthorId = author.AuthorId,
            PublisherId = publisher.PublisherId,
            PublishDate = bookDto.PublishDate,
            Category = bookDto.Category
        };

        _dbContext.Books.Add(book);
        _dbContext.SaveChanges();

        return true;
    }
}