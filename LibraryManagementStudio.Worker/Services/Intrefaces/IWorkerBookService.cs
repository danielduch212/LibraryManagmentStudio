using LibraryManagementStudio.Worker.Dtos.Book;

namespace LibraryManagementStudio.Worker.Services.Intrefaces;

public interface IWorkerBookService
{
    bool CreateBook(CreateBookDto bookDto);
}