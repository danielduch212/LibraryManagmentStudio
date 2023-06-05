using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.ReportData;

namespace LibraryManagementStudio.Worker.Services;

public class ReportService
{

    private readonly LibraryDbContext _dbContext;

    public ReportService(LibraryDbContext _dbContext)
    {
        this._dbContext = _dbContext;

    }


    //public List<ReportData1> returnData(User user, DateTime dateFrom, DateTime dateTo)
    //{

    //    return 
    //}

    //public List<ReportData2> returnData(Author author, Publisher publisher, bool isActive, CategoryType category)
   // {

    //}


}