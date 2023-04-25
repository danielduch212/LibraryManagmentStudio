using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementStudio.Models;

public class Publisher
{
    public int PublisherId { get; set; }
    
    public string Name { get; set; }
    
    //Relationships
    public ICollection<Book> Books { get; set; }
}