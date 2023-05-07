namespace LibraryManagementStudio.User.Dtos.BookBorrow;

public class BookBorrowDto
{
    public int BookBorrowId { get; set; }
    
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string AuthorName { get; set; } = null!;
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Status { get; set; } = null!;
}