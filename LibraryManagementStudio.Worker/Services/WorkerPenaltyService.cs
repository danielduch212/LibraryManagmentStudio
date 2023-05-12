using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Dtos.Penalty;
using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Worker.Services.Intrefaces;

namespace LibraryManagementStudio.Worker.Services
{
    public class WorkerPenaltyService : IWorkerPenaltyService
    {
        private readonly LibraryDbContext _dbContext;

        public WorkerPenaltyService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        public List<PenaltyDto> GetNotPaidPenalties()
        {
            var query = _dbContext.Penalties
                .Where(x => x.IsPaid == false);

            var penalties = query.Select(x => new PenaltyDto()
            {
                PenaltyId = x.PenaltyId,
                Description = x.Description,
                Price = x.Price,
                IsPaid = x.IsPaid,
                BookBorrowId = x.BookBorrowId,
                WorkerId = x.WorkerId,
                UserId = x.BookBorrow.UserId,
                BookCopyId = x.BookBorrow.BookCopyId,
                UserFirstName = x.BookBorrow.User.FirstName,
                UserLastName = x.BookBorrow.User.LastName,
                BookTitle = x.BookBorrow.BookCopy.Book.Title
            });
            
            return penalties.ToList();
        }

        public List<PenaltyDto> GetPaidPenalties()
        {
            var query = _dbContext.Penalties
                .Where(x => x.IsPaid == true);
            
            var penalties = query.Select(x => new PenaltyDto()
            {
                PenaltyId = x.PenaltyId,
                Description = x.Description,
                Price = x.Price,
                IsPaid = x.IsPaid,
                BookBorrowId = x.BookBorrowId,
                WorkerId = x.WorkerId,
                UserId = x.BookBorrow.UserId,
                BookCopyId = x.BookBorrow.BookCopyId,
                UserFirstName = x.BookBorrow.User.FirstName,
                UserLastName = x.BookBorrow.User.LastName,
                BookTitle = x.BookBorrow.BookCopy.Book.Title
            });

            return penalties.ToList();
        }
        
        public void ErasePenalty(int penaltyId)
        {
            var query = _dbContext.Penalties
                .FirstOrDefault(x => x.PenaltyId.Equals(penaltyId));

            query.IsPaid = true;
        }

        public void CreatePenalty(CreatePenaltyDto penaltyDto)
        {
            var penalty = new Penalty()
            {
                Description = penaltyDto.Description,
                Price = penaltyDto.Price,
                IsPaid = false,
                BookBorrowId = penaltyDto.BookBorrowId,
                WorkerId = penaltyDto.WorkerId
            };

            _dbContext.Penalties.Add(penalty);
            _dbContext.SaveChanges();
        }
    }
}
