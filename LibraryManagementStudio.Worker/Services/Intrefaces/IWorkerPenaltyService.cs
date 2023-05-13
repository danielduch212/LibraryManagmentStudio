using LibraryManagementStudio.Worker.Dtos.Penalty;

namespace LibraryManagementStudio.Worker.Services.Intrefaces;

public interface IWorkerPenaltyService
{
    List<PenaltyDto> GetPenalties(bool status);
    List<PenaltyDto> GetPenaltyByEmail(string email,bool status);
    void ErasePenalty(int penaltyId);
    void CreatePenalty(CreatePenaltyDto penaltyDto);


}