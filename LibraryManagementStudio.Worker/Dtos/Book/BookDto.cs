using LibraryManagementStudio.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Dtos.Book
{
    public class BookDto
    {
        public int BookId { get; set; }

        public string Title { get; set; } = null!;
        public string AuthorName { get; set; } = null!;
        public string PublisherName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public CategoryType Category { get; set; }
        public DateTime PublishDate { get; set; }
        public int BookCopiesCount { get; set; }
        public int AvailibleBookCopiesCount { get; set; }
    }
}
