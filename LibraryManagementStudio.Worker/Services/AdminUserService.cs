using LibraryManagementStudio.Data;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Worker.Dtos.User;
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

        public List<UserDto> getUsers()
        {

            var query = _dbContext.Users
           .Select(x => new UserDto()
           {
               UserId = x.UserId,
               EmailAddress = x.EmailAddress,
               FirstName = x.FirstName,
               LastName = x.LastName,
               Street = x.Street,
               PostalCode = x.PostalCode,
               City = x.City,
               BookBorrows = x.BookBorrows,
               BookBorrowsCount = x.BookBorrows.Count


           }) ;

            var users = query.ToList();

            return users;
        }

        public void CreateUser(LibraryManagementStudio.Data.Models.User user)
        {

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public LibraryManagementStudio.Data.Models.User findUser(int Id)
        {
            var query = _dbContext.Users
                .FirstOrDefault(x => x.UserId.Equals(Id));
            return query;
        }

        public LibraryManagementStudio.Data.Models.User getUserByEmail(string email)
        {
            var query = _dbContext.Users
                .FirstOrDefault(x => x.EmailAddress.Equals(email));
            return query;
        }

        public  List<UserDto> searchUser(string email)
        {
            var query = _dbContext.Users
            .Where(x => x.EmailAddress.Contains(email));
            var users = query.Select(x => new UserDto()
            { 
            

                UserId = x.UserId,
                EmailAddress = x.EmailAddress,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Street = x.Street,
                PostalCode = x.PostalCode,
                City = x.City,
                BookBorrows = x.BookBorrows,
                BookBorrowsCount = x.BookBorrows.Count,

            });

            return users.ToList();
            

        }


        public LibraryManagementStudio.Data.Models.User findUserRow(int idFromCell)
        {


            var query = _dbContext.Users
                .FirstOrDefault(x => x.UserId == idFromCell);
            return query;


        }

    }
}
