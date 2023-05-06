using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.User.Dtos.BookBorrow;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;
using LibraryManagementStudio.User.Views;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.User.Services;

public class UserBookBorrowService : IUserBookBorrowService
{
    private readonly LibraryDbContext _dbContext;
    private readonly IEmailService _emailService;

    public UserBookBorrowService(LibraryDbContext dbContext, IEmailService emailService)
    {
        _dbContext = dbContext;
        _emailService = emailService;
    }

    public bool BorrowBook(BookCopy bookCopy, UserDto userDto)
    {
        var pickupCode = ProvideUniqueBookStoreCode();
        var returnCode = ProvideUniqueBookStoreCode(pickupCode);

        var bookBorrow = new BookBorrow()
        {
            BookCopyId = bookCopy.BookCopyId,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(14),
            status = BorrowedBookStatus.Requested,
            IsActive = true,
            UserId = userDto.UserId,
            BookStoreCodes = new List<BookStoreCode>()
            {
                new BookStoreCode()
                {
                    Code = pickupCode,
                    CodeType = CodeType.odbior
                },
                new BookStoreCode()
                {
                    Code = returnCode,
                    CodeType = CodeType.zwrot
                }
            }
        };
        
        _dbContext.Attach(bookCopy);
        bookCopy.IsAvailable = false;
        _dbContext.Entry(bookCopy).Property(x => x.IsAvailable).IsModified = true;

        _dbContext.BookBorrows.Add(bookBorrow);
        _dbContext.SaveChanges();
        
        _emailService.SendCodeMessage(userDto.EmailAddress, pickupCode, returnCode, bookCopy.Book.Title);

        return true;
    }

    public void ReturnBook(int bookBorrowId)
    {
        // var bookBorrow = _dbContext.BookBorrows
        //     .Include(x => x.BookCopy)
        //     .ThenInclude(y => y.Book)
        //     .FirstOrDefault(x => x.BookBorrowId == bookBorrowId);
    }
    
    public List<BookBorrowDto> GetBorrowedBooks(int userId, string bookName = "")
    {
        var query = _dbContext.BookBorrows
            .Include(x => x.BookCopy)
            .ThenInclude(y => y.Book)
            .ThenInclude(z => z.Author)
            .Where(x => x.UserId == userId && x.IsActive && x.BookCopy.Book.Title.Contains(bookName))
            .Select(x => new BookBorrowDto()
            {
                BookBorrowId = x.BookBorrowId,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = EnumDescriptor.GetEnumDescription(x.status),
                Title = x.BookCopy.Book.Title,
                Category = EnumDescriptor.GetEnumDescription(x.BookCopy.Book.Category),
                AuthorName = x.BookCopy.Book.Author.Name,
            });
        
        var bookBorrows = query.ToList();
        
        return bookBorrows;
    }
    
    public int GetBorrowedBooksCount(int userId)
    {
        var count = _dbContext.BookBorrows
            .Count(x => x.UserId == userId && x.IsActive);

        return count;
    }

    private string ProvideUniqueBookStoreCode()
    {
        while (true)
        {
            var code = Guid.NewGuid().ToString();
            var exisitingCode = _dbContext.BookStoreCodes.FirstOrDefault(x => x.Code == code);
            
            if (exisitingCode == null)
            {
                return code;
            }
        }
    }
    
    private string ProvideUniqueBookStoreCode(string bookStoreCode)
    {
        while (true)
        {
            var code = Guid.NewGuid().ToString();
            var exisitingCode = _dbContext.BookStoreCodes.FirstOrDefault(x => x.Code == code);
            
            if (exisitingCode == null && code != bookStoreCode)
            {
                return code;
            }
        }
    }
}