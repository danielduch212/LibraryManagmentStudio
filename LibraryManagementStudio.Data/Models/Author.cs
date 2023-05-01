namespace LibraryManagementStudio.Data.Models;

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    
    //Relationships
    public ICollection<Book> Books { get; set; }
}