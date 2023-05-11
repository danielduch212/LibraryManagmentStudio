namespace LibraryManagementStudio.User.Dtos.Penalty;

public class PenaltyDto
{
    public int PenaltyId { get; set; }

    public string BookTitle { get; set; } = null!;
    public double Price { get; set; }
    public string Description { get; set; } = null!;
    public DateTime ImpositionDate { get; set; }
}