using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Services
{
    internal class WorkerService
    {
        private readonly LibraryDbContext _dbContext;

        WorkerService(LibraryDbContext dbContext)
        {
            this._dbContext = dbContext;

        }

        public List<LibraryManagementStudio.Data.Models.Worker> getWorkers()
        {
            var query = _dbContext.Workers
           .Select(x => new LibraryManagementStudio.Data.Models.Worker()
           {
               WorkerId = x.WorkerId,
               Type = x.Type,
               FirstName = x.FirstName,
               LastName = x.LastName,
               EmailAddress = x.EmailAddress,
               Password = x.Password,
               Books = x.Books,
               BookBorrows = x.BookBorrows,
               Users = x.Users,




           });

            var workers = query.ToList();

            return workers;


        }
    }
}
