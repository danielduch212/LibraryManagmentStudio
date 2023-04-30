using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Dtos.Book;

public class CreateBookDto
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public DateTime PublishDate { get; set; }
    public CategoryType Category { get; set; }
    
    public int AuthorId { get; set; }
    public int PublisherId { get; set; }
}