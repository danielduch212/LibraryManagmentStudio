using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Dtos.BookCopy;

public class BookCopyDto
{
    public int BookCopyId { get; set; }
    
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string AuthorName { get; set; } = null!;
    public string PublisherName { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public CategoryType Category { get; set; }
}