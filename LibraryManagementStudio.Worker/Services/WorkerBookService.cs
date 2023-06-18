using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.Book;
using LibraryManagementStudio.Worker.Services.Intrefaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace LibraryManagementStudio.Worker.Services;

public class WorkerBookService : IWorkerBookService
{
    private readonly LibraryDbContext _dbContext;

    public WorkerBookService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public void AddBook(Book book)
    {
        _dbContext.Books.Add(book);
        _dbContext.SaveChanges();
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
            IsActive = true,
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
            .Where(x => x.IsActive == true);

            // .Include(x => x.Author)
            // .Include(x => x.Publisher)
            // .Include(x => x.BookCopies);
            
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
            AvailibleBookCopiesCount = x.BookCopies.Count(y => y.IsAvailable==true && y.IsActive==true)

        });
        
        return books.ToList();
    }
    public List<BookDto> GetBookByTitle(string bookname)
    {
        var query = _dbContext.Books
            .Include(x => x.Author)
            .Include(x => x.Publisher)
            .Include(x => x.BookCopies)
            .Where(x => x.Title.Contains(bookname) && x.IsActive == true)
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
    public Book getBookFromId(int idFromCell)
    {
        
        
        var query = _dbContext.Books
            .FirstOrDefault(x => x.BookId== idFromCell && x.IsActive ==true);
        return query;


    }

    public BookCopy getAvailibleCopy(string title)
    {
        var query = _dbContext.BookCopies
            .FirstOrDefault(x => x.Book.Title == title && x.IsAvailable == true && x.IsActive == true);
        
        return query;


    }
    public void CreateNewBookBorrow(BookBorrow bookBorrow, BookCopy bookCopy)
    {
        bookCopy.IsAvailable = false;
        _dbContext.BookBorrows.Add(bookBorrow);
        _dbContext.SaveChanges();

    }

    public void AddBookCopy(BookCopy bookCopy)
    {
        _dbContext.BookCopies.Add(bookCopy);
        _dbContext.SaveChanges();
    }
    public void AddBookCopies(Book book,int howMany)
    {
        for(int i=0; i<howMany; i++) 
        {
            BookCopy bookCopy = new BookCopy()
            {
                IsActive = true,
                IsAvailable = true,
                Status = Data.Models.Enums.BookCopyStatus.dobry,
                BookBorrows = new List<BookBorrow>(),
                Book = book,
                BookId = book.BookId,

            };
            _dbContext.BookCopies.Add(bookCopy);
            _dbContext.SaveChanges();

        }
        

    }

    public void EraseCopy(int id)
    {
        var query = _dbContext.BookCopies
           .FirstOrDefault(x => x.BookCopyId == id);
        query.IsActive = false;

    }

    public List<BookBorrow> GetAllUserBorrows(LibraryManagementStudio.Data.Models.User user)
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.User == user && x.IsActive == true);
        return query.ToList();
    }

    public BookCopy findBookCopy(int id)
    {
        var query = _dbContext.BookCopies
            .FirstOrDefault(x => x.BookCopyId==id && x.IsActive == true);
        return query; 
    }
    
    public void returnBookBorrow(int bookBorrowId)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.BookCopy)
            .FirstOrDefault(x => x.BookBorrowId == bookBorrowId);

        if (bookBorrow == null) 
            return;
        
        bookBorrow.IsActive = false;
        bookBorrow.Status = Data.Models.Enums.BorrowedBookStatus.Returned;
        bookBorrow.BookCopy.IsAvailable = true;

        _dbContext.SaveChanges();
    }
    
    public List<Worker.Dtos.BookBorrow.BookBorrowToShow> GetUsersBorrowedBooks(LibraryManagementStudio.Data.Models.User user)
    {
        var query = _dbContext.BookBorrows
           .Where(x => x.User == user && x.IsActive == true)
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
    
    public int GetUsersCurrentBorrowedBooks(LibraryManagementStudio.Data.Models.User user)
    {
        var query = _dbContext.BookBorrows
           .Where(x => x.User == user && x.IsActive == true);

        return query.Count();

    }

    public BookBorrow getBookBorrow(int id)
    {
        var query = _dbContext.BookBorrows
            .FirstOrDefault(x => x.BookBorrowId==id);
        return query;
         

    }

    public string ProvideUniqueBookStoreCode()
    {
        while (true)
        {
            var code = Guid.NewGuid().ToString().Substring(0, 8);
            var exisitingCode = _dbContext.BookStoreCodes.FirstOrDefault(x => x.Code == code);

            if (exisitingCode == null)
            {
                return code;
            }
        }
    }

    
    public void EraseBook(Book book)
    {

        book.IsActive = false;
        _dbContext.SaveChanges();
    }
}