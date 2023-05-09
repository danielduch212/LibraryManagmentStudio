using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Services
{
    
    internal class AdminUserService
    {
        private readonly LibraryDbContext _dbContext;

        public AdminUserService(LibraryDbContext _dbContext)
        {
            this._dbContext = _dbContext;

        }

        List<LibraryManagementStudio.Data.Models.User> getUsers()
        {

            var query = _dbContext.Users
           .Select(x => new LibraryManagementStudio.Data.Models.User()
           {
               UserId = x.UserId,
               EmailAddress = x.EmailAddress,
               Password = x.Password,
               FirstName = x.FirstName,
               LastName = x.LastName,
               DateOfBirth = x.DateOfBirth,
               Street = x.Street,
               PostalCode = x.PostalCode,
               City = x.City,
               Country = x.Country,
               CreationDate = x.CreationDate,
               WorkerId = x.WorkerId,
               Worker = x.Worker,
               BookBorrows = x.BookBorrows,



           });

            var users = query.ToList();

            return users;
        }

        public void CreateUser(LibraryManagementStudio.Data.Models.User user)
        {

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }



    }
}
