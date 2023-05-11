using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.Penalty;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Services;

public class UserPenaltyService : IUserPenaltyService
{
    private readonly LibraryDbContext _dbContext;

    public UserPenaltyService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IEnumerable<PenaltyDto> GetPenalties(int userId)
    {
        var query = _dbContext.Penalties
            .Where(x => x.BookBorrow.UserId == userId);

        var penaltyDtos = query.Select(x => new PenaltyDto()
        {
            PenaltyId = x.PenaltyId,
            BookTitle = x.BookBorrow.BookCopy.Book.Title,
            Price = x.Price,
            Description = x.Description
        });
        
        return penaltyDtos.ToList();
    }
    
    public IEnumerable<PenaltyDto> GetPenalties(int userId, bool isPaid)
    {
        var query = _dbContext.Penalties
            .Where(x => x.BookBorrow.UserId == userId && x.IsPaid == isPaid);
        
        var penaltyDtos = query.Select(x => new PenaltyDto()
        {
            PenaltyId = x.PenaltyId,
            BookTitle = x.BookBorrow.BookCopy.Book.Title,
            Price = x.Price,
            Description = x.Description
        });
        
        return penaltyDtos.ToList();
    }
}