using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.ReportData;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
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

    
    //wszyscy autorzy
    //wszyscy publisherzy
    //wszsytkie kategorie



    public List<ReportData2> returnData(Author? author, Data.Models.Publisher? publisher, bool isActive, CategoryType? category)
    {
        var query = _dbContext.BookCopies
            .Where(x => (author == null || x.Book.Author == author) &&
                        (publisher == null || x.Book.Publisher == publisher) &&
                        x.Book.IsActive == isActive  &&
                        (category == null || x.Book.Category == category));
            
        var data = query.Select(x => new ReportData2()
        {
            BookId = x.Book.BookId,
            Title = x.Book.Title,
            Description = x.Book.Description,

        });
        _dbContext.Database.CloseConnection();

        var uniqueData = data.GroupBy(x => x.BookId)
                     .Select(group => group.First())
                     .ToList();

        
        return uniqueData.ToList();
    }
    public List<ReportData2> returnData2(List<ReportData2> list)
    {
        foreach (ReportData2 item in list)
        {
            var query1 = _dbContext.BookBorrows
                .Where(x => x.BookCopy.Book.Title == item.Title);
            item.AllTimeBookBorrowsCount = query1.Count();

            _dbContext.Database.CloseConnection();

        }

        return list;
    }

    public List<BookCopy> returnData3()
    {
        var query = _dbContext.BookCopies
            .Where(x => x.BookBorrows.Count() == 0);


        _dbContext.Database.CloseConnection();
        return query.ToList();
    }
    public List<ReportData2> returnData4(List<BookCopy> bookCopiesWithNoBorrows, List<ReportData2> listWithExistingBookBorrows)
    {

        List<ReportData2> resultData = new List<ReportData2>();
        foreach (BookCopy item in bookCopiesWithNoBorrows)
        {

            var query1 = _dbContext.BookBorrows
                .Where(x => x.BookCopy.Book.Title == item.Book.Title);
            
            if(query1 == null)
            {
                ReportData2 reportData = new ReportData2()
                {
                    BookId = item.Book.BookId,
                    Title = item.Book.Title,
                    Description = item.Book.Description,
                    AllTimeBookBorrowsCount = 0,

                };
                resultData.Add(reportData);
            }
            _dbContext.Database.CloseConnection();
        }
        var uniqueData = resultData.GroupBy(x => x.BookId)
                     .Select(group => group.First())
                     .ToList();

        listWithExistingBookBorrows.AddRange(uniqueData);
        return listWithExistingBookBorrows;
    }
    public Author findAuthor(string author)
    {

        var query = _dbContext.Authors
            .FirstOrDefault(x => x.Name.Equals(author));
        return query;
    }

    public LibraryManagementStudio.Data.Models.Publisher findPublisher(string publisher)
    {

        var query = _dbContext.Publishers
            .FirstOrDefault(x => x.Name.Equals(publisher));
        return query;
    }
}