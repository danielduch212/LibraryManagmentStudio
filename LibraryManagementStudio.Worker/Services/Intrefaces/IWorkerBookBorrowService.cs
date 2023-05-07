using LibraryManagementStudio.Worker.Dtos.BookBorrow;

namespace LibraryManagementStudio.Worker.Services.Intrefaces;

public interface IWorkerBookBorrowService
{
    List<BookBorrowDto> GetBorrowedBooks();
    List<BookBorrowDto> GetReturnedBooks();
    void AcceptBookBorrow(int bookBorrowId);
    void AcceptBookReturn(int bookBorrowId);
}