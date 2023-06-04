using LibraryManagementStudio.Data.Models.Enums;

namespace LibraryManagementStudio.Data.Models;

public class BookCopy
{
    public int BookCopyId { get; set; }

    public bool IsActive { get; set; }
    public bool IsAvailable { get; set; }
    public BookCopyStatus Status { get; set; }
    
    //Relationships
    public ICollection<BookBorrow> BookBorrows { get; set; }
    
    public int BookId { get; set; } 
    public Book Book { get; set; }
}