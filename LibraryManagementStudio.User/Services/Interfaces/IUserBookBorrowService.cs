using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserBookBorrowService
{
    bool BorrowBook(BookCopy bookCopy, UserDto userDto);
}