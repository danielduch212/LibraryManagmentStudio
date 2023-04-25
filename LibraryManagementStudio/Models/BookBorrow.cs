using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Models;

public class BookBorrow
{
    public int BookBorrowId { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public BorrowedBookStatus status { get; set; }
    
    //Relationships
    public int? WorkerId { get; set; }
    public Worker? Worker { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public int BookCopyId { get; set; }
    public BookCopy BookCopy { get; set; }
    
    public Penalty? Penalty { get; set; }

    public ICollection<BookStoreCode> BookStoreCodes { get; set; }
}