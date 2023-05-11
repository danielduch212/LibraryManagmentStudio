using LibraryManagementStudio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Dtos.User
{
    internal class UserDto
    {
        public int UserId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        //Relationships

        public ICollection<LibraryManagementStudio.Data.Models.BookBorrow> BookBorrows { get; set; }
        public int BookBorrowsCount { get; set; }
    }
}
