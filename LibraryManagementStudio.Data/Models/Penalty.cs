namespace LibraryManagementStudio.Data.Models;

public class Penalty
{
    public int PenaltyId { get; set; }

    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime ImpositionDate { get; set; }
    public bool IsPaid { get; set; }
    
    //Relationships
    public int BookBorrowId { get; set; }
    public BookBorrow BookBorrow { get; set; }

    public int WorkerId { get; set; }
    public Worker Worker { get; set; }
}