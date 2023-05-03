using LibraryManagementStudio.Data.Models;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserBookCopyService
{
    BookCopy? GetAvailableBookCopy(int bookId);
}