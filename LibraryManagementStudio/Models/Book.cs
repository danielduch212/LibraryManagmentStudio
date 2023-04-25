using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Models;

public class Book
{
    public int BookId { get; set; }
    
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PublishDate { get; set; }
    public CategoryType Category { get; set; }

    //Relationships
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    
    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; }

    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    public ICollection<BookCopy> BookCopies { get; set; }
}