namespace LibraryManagementStudio.Data.Models;

public class User
{
    public int UserId { get; set; }
    
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public DateTime CreationDate { get; set; }

    //Relationships
    public int? WorkerId { get; set; }
    public Worker? Worker { get; set; }

    public ICollection<BookBorrow> BookBorrows { get; set; }
}