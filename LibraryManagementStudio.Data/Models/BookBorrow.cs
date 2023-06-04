using LibraryManagementStudio.Data.Models.Enums;

namespace LibraryManagementStudio.Data.Models;

public class BookBorrow
{
    public int BookBorrowId { get; set; }
    
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? ReturnDate { get; set; }
    public bool IsActive { get; set; }
    public BorrowedBookStatus Status { get; set; }
    
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