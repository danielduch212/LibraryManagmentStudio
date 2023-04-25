using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Models;

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
    public ICollection<User> Users { get; set; }
}