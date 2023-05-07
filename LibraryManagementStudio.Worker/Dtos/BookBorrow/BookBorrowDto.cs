namespace LibraryManagementStudio.Worker.Dtos.BookBorrow;

public class BookBorrowDto
{
    public int BookBorrowId { get; set; }
    
    public int BookCopyId { get; set; }
    public string BookTitle { get; set; } = null!;
    public string UserEmailAddress { get; set; } = null!;
}