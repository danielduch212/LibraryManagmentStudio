using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.ReportData;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementStudio.Worker.Services;

public class ReportService
{

    private readonly LibraryDbContext _dbContext;

    public ReportService(LibraryDbContext _dbContext)
    {
        this._dbContext = _dbContext;

    }


    public List<ReportData1> returnData(int userId, DateTime dateFrom, DateTime dateTo)
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.UserId==userId && x.StartDate >= dateFrom && x.StartDate <= dateTo);
        var bookBorrows = query.Select(x => new ReportData1()
        {
            BookBorrowId = x.BookBorrowId,
            Title = x.BookCopy.Book.Title,
            Status = x.Status,
            UserId = x.UserId,
        });

        return bookBorrows.ToList();
    }

    
    public List<ReportData2> returnData(Author author, Publisher publisher, bool isActive, CategoryType category)
    {
        var query = _dbContext.BookBorrows
            .Where(x => x.BookCopy.Book.Author == author && x.BookCopy.Book.Publisher == publisher && x.BookCopy.Book.IsActive == isActive && x.BookCopy.Book.Category == category);

        var data = query.Select(x => new ReportData2()
        {
            BookId = x.BookCopy.Book.BookId,
            Title = x.BookCopy.Book.Title,
            Description = x.BookCopy.Book.Description,
            AllTimeBookBorrowsCount = query.Count(),
        });

        return data.ToList();
    }
    public Author findAuthor(string author)
    {

        var query = _dbContext.Authors
            .FirstOrDefault(x => x.Name.Equals(author));
        return query;
    }

    public Publisher findPublisher(string publisher)
    {

        var query = _dbContext.Publishers
            .FirstOrDefault(x => x.Name.Equals(publisher));
        return query;
    }
}