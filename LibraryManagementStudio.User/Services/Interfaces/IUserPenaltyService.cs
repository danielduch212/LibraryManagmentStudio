using LibraryManagementStudio.User.Dtos.Penalty;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserPenaltyService
{
    IEnumerable<PenaltyDto> GetPenalties(int userId);
    IEnumerable<PenaltyDto> GetPenalties(int userId, bool isPaid);
}