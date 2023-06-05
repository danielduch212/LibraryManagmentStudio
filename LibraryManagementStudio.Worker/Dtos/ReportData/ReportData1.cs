using LibraryManagementStudio.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Dtos.ReportData
{
    public class ReportData1
    {


        public int BookBorrowId { get; set; }
        public string Title { get; set; }
        public BorrowedBookStatus Status { get; set; }
        public int UserId { get; set; }

    }
}
