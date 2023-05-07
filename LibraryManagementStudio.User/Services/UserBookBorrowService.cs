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
            StartDate = null,
            EndDate = null,
            Status = BorrowedBookStatus.Requested,
            IsActive = true,
            UserId = userDto.UserId,
            BookStoreCodes = new List<BookStoreCode>()
            {
                new()
                {
                    Code = pickupCode,
                    CodeType = CodeType.odbior
                },
                new()
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

        return true;
    }

    public bool ReturnBook(int bookBorrowId)
    {
        var bookBorrow = _dbContext.BookBorrows
            .Include(x => x.User)
            .Include(x => x.BookStoreCodes)
            .Include(x => x.BookCopy)
            .ThenInclude(x => x.Book)
            .FirstOrDefault(x => x.BookBorrowId == bookBorrowId);
        
        if (bookBorrow == null)
            return false;
            
        _emailService.SendReturnCodeMessage(bookBorrow.User.EmailAddress, bookBorrow.BookStoreCodes.First(x => x.CodeType == CodeType.zwrot).Code, bookBorrow.BookCopy.Book.Title);
        return true;
    }
    
    public List<BookBorrowDto> GetBorrowedBooks(int userId, string bookName = "")
    {
        var query = _dbContext.BookBorrows
            .Include(x => x.User)
            .Include(x => x.BookCopy)
            .ThenInclude(y => y.Book)
            .Where(x => x.UserId == userId && x.IsActive && x.BookCopy.Book.Title.Contains(bookName))
            .Select(x => new BookBorrowDto()
            {
                BookBorrowId = x.BookBorrowId,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                Status = EnumDescriptor.GetEnumDescription(x.Status),
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
            var code = Guid.NewGuid().ToString().Substring(0, 8);
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
            var code = Guid.NewGuid().ToString().Substring(0, 8);
            var exisitingCode = _dbContext.BookStoreCodes.FirstOrDefault(x => x.Code == code);
            
            if (exisitingCode == null && code != bookStoreCode)
            {
                return code;
            }
        }
    }
}