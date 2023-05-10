using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Dtos.Penalty
{
    public class PenaltyDto
    {
        public int PenaltyId { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsPaid { get; set; }

        //Relationships
        public int BookBorrowId { get; set; }
        public int WorkerId { get; set; }

        //to z tabeli BookBorrows
        public int UserId { get; set; }
        public int BookCopyId { get; set; }

        //to z tabeli Users
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        
        
        // to z tabeli Book
        public string BookTitle { get; set; }


    }
}
