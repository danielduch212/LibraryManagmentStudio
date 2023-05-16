using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementStudio.Data.Models;

namespace LibraryManagementStudio.Worker.Dtos.BookBorrow
{
    public class BookBorrowToShow
    {
        public int BookBorrowId { get; set; }
        public string bookTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public LibraryManagementStudio.Data.Models.Enums.BorrowedBookStatus Status { get; set; }

        //Relationships
        public int? WorkerId { get; set; }

        public int UserId { get; set; }

        public int BookCopyId { get; set; }


        
        
    }
}

