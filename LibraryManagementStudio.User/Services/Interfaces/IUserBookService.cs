using LibraryManagementStudio.User.Dtos.Book;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserBookService
{
    IEnumerable<BookDto> GetBooks();
    IEnumerable<BookDto> GetBooks(string title);
}