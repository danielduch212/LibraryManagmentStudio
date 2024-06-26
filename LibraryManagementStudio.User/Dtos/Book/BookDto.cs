using LibraryManagementStudio.Data.Models.Enums;

namespace LibraryManagementStudio.User.Dtos.Book;

public class BookDto
{
    public int BookId { get; set; }
    
    public string Title { get; set; } = null!;
    public string AuthorName { get; set; } = null!;
    public string PublisherName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public CategoryType Category { get; set; }
    public int BookCopiesCount { get; set; }
}