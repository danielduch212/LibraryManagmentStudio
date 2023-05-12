namespace LibraryManagementStudio.Worker.Dtos.Penalty;

public class CreatePenaltyDto
{
    public string Description { get; set; } = null!; 
    public double Price { get; set; }
    public bool IsPaid { get; set; }
    public int BookBorrowId { get; set; }
    public int WorkerId { get; set; }
}