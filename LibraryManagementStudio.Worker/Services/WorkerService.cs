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
    public class WorkerService
    {
        private readonly LibraryDbContext _dbContext;

        public WorkerService(LibraryDbContext dbContext)
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

        public LibraryManagementStudio.Data.Models.Worker getWorker(string login)
        {
            var query = _dbContext.Workers
               .FirstOrDefault(x => x.EmailAddress.Equals(login));
            return query;

        }

        public LibraryManagementStudio.Data.Models.Worker checkLoginData(string login, string password)
        {

            var query = _dbContext.Workers
               .FirstOrDefault(x => x.EmailAddress == login);
            if(query != null)
            {
                if (query.Password == password)
                {
                    return query;
                }
                else
                {
                    return null;
                }

            }
            return null;
            
        }
        public List<LibraryManagementStudio.Data.Models.Worker> searchWorkers(string email)
        {
            var query = _dbContext.Workers
            .Where(x => x.EmailAddress.Contains(email));
            var users = query.Select(x => new LibraryManagementStudio.Data.Models.Worker()
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

            return users.ToList();

        }
        public LibraryManagementStudio.Data.Models.Worker findWorkerRow(string idFromCell)
        {


            var query = _dbContext.Workers
                .FirstOrDefault(x => x.WorkerId == Int32.Parse(idFromCell));
            return query;


        }
    }
}
