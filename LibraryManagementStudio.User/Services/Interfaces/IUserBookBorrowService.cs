using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.User.Dtos.BookBorrow;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserBookBorrowService
{
    bool BorrowBook(BookCopy bookCopy, UserDto userDto);
    bool ReturnBook(int bookBorrowId);
    List<BookBorrowDto> GetBorrowedBooks(int userId, string bookName = "");
    int GetBorrowedBooksCount(int userId);
}