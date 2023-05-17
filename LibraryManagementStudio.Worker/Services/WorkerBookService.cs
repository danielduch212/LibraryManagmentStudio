using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Dtos.Book;
using LibraryManagementStudio.Worker.Services.Intrefaces;
using Microsoft.EntityFrameworkCore;

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

    public List<BookDto> GetBooks()
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
            BookCopiesCount = x.BookCopies.Count(),
            AvailibleBookCopiesCount = x.BookCopies.Count(y => y.IsAvailable)

        });
        
        return books.ToList();
    }
    public List<BookDto> GetBookByTitle(string bookname)
    {
        var query = _dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.Publisher)
            .Include(x => x.BookCopies)
            .Where(x => x.Title.Contains(bookname))
            .Select(x => new BookDto()
            {
                BookId = x.BookId,
                Title = x.Title,
                Description = x.Description,
                AuthorName = x.Author.Name,
                PublisherName = x.Publisher.Name,
                PublishDate = x.PublishDate,
                Category = x.Category,
                BookCopiesCount = x.BookCopies.Count(),
                AvailibleBookCopiesCount = x.BookCopies.Count(y => y.IsAvailable)
            });

        return query.ToList();

        
    }
    public Book getBookFromString(string stringFromRow)
    {
        string[] parts = stringFromRow.Split("/t");
        var id = parts[0];
        var query = _dbContext.Books
            .FirstOrDefault(x => x.BookId.Equals(id));
        return query;


    }

    public BookCopy getAvailibleCopy(string title)
    {
        var query = _dbContext.BookCopies
            .FirstOrDefault(x => x.Book.Title == title);
        
        return query;


    }
    public void CreateNewBookBorrow(BookBorrow bookBorrow)
    {
        _dbContext.BookBorrows.Add(bookBorrow);
        _dbContext.SaveChanges();

    }
    public void AddBookCopies(Book book,int howMany)
    {
        for(int i=0; i<howMany; i++) 
        {
            BookCopy bookCopy = new BookCopy()
            {
                IsAvailable = true,
                Status = Data.Models.Enums.BookCopyStatus.dobry,
                BookBorrows = new List<BookBorrow>(),
                Book = book,
                BookId = book.BookId,

            };
            book.BookCopies.Add(bookCopy);

        }
        

    }

    public void EraseCopy(int id)
    {
        var query = _dbContext.BookCopies
           .FirstOrDefault(x => x.BookCopyId == id);
        //dodac to pozniej 

    }

    public List<BookBorrow> GetAllUserBorrows(LibraryManagementStudio.Data.Models.User user)
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.User == user);
        return query.ToList();
    }

    public void returnBookBorrow(string data)
    {
        string[] parts = data.Split("/t");
        var id = parts[0];
        var query = _dbContext.BookBorrows
            .FirstOrDefault(x => x.BookBorrowId.Equals(id));
        query.IsActive = false;
        // data oddania ksiazki
        
        query.Status = Data.Models.Enums.BorrowedBookStatus.Returned;
        query.BookCopy.IsAvailable = true;
        
    }
    public List<Worker.Dtos.BookBorrow.BookBorrowToShow> GetUsersBorrowedBooks(User user)
    {
        var query = _dbContext.BookBorrows
           .Where(x => x.User == user && x.IsActive ==true)//jeszcze tu powinno byc czy jest aktywne
           .Select(x => new Worker.Dtos.BookBorrow.BookBorrowToShow()
            {
                BookBorrowId = x.BookBorrowId,
                bookTitle = x.BookCopy.Book.Title,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = x.Status,
                WorkerId = x.WorkerId,
                UserId = x.UserId,
                BookCopyId = x.BookCopyId,
            });
        return query.ToList();

    }

    public BookBorrow getBookBorrow(int id)
    {
        var query = _dbContext.BookBorrows
            .FirstOrDefault(x => x.BookBorrowId.Equals(id));
        return query;
         

    }
}