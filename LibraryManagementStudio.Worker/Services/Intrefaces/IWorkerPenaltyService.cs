using LibraryManagementStudio.Worker.Dtos.Penalty;

namespace LibraryManagementStudio.Worker.Services.Intrefaces;

public interface IWorkerPenaltyService
{
    List<PenaltyDto> GetNotPaidPenalties();
    List<PenaltyDto> GetPaidPenalties();
    void ErasePenalty(int penaltyId);
    void CreatePenalty(CreatePenaltyDto penaltyDto);
}