using LibraryManagementStudio.Data.Models.Enums;

namespace LibraryManagementStudio.Data.Models;

public class Worker
{
    public int WorkerId { get; set; }
    
    public WorkerType Type { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    
    //Relationships
    public ICollection<Book> Books { get; set; }
    public ICollection<BookBorrow> BookBorrows { get; set; }
    public ICollection<Data.Models.User> Users { get; set; }
    public ICollection<Data.Models.Penalty> Penalties { get; set; }
}