using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Models;

public class BookCopy
{
    public int BookCopyId { get; set; }

    public bool IsAvailable { get; set; }
    public BookCopyStatus Status { get; set; }
    
    //Relationships
    public BookBorrow BookBorrow { get; set; }
    
    public int BookId { get; set; }
    public Book Book { get; set; }
}