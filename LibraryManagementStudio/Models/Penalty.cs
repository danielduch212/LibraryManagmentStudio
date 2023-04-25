using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementStudio.Models;

public class Penalty
{
    public int PenaltyId { get; set; }

    public string Description { get; set; }
    public double Price { get; set; }
    public bool IsPaid { get; set; }
    
    //Relationships
    public int BookBorrowId { get; set; }
    public BookBorrow BookBorrow { get; set; }
}