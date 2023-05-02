using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Services;

public class UserAuthService
{
    private readonly LibraryDbContext _dbContext;

    public UserAuthService(LibraryDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public bool FindUser(string emailAddress)
    {
        var user = _dbContext.Users.FirstOrDefault(x => x.EmailAddress.ToLower() == emailAddress.ToLower());
        
        return user != null;
    }
    
    public bool ValidateCredentials(string emailAddress, string password)
    {
        var user = _dbContext.Users.FirstOrDefault(x => x.EmailAddress.ToLower() == emailAddress.ToLower());
        
        if (user == null)
        {
            return false;
        }

        var verifyPassword = PasswordHelper.VerifyPassword(password, user.Password);

        return verifyPassword;
    }
    
    public void CreateUser(CreateUserDto userToCreateDto)
    {
        var user = new Data.Models.User()
        {
            FirstName = userToCreateDto.FirstName,
            LastName = userToCreateDto.LastName,
            EmailAddress = userToCreateDto.EmailAddress,
            Password = PasswordHelper.HashPassword(userToCreateDto.Password),
            DateOfBirth = userToCreateDto.DateOfBirth,
            Street = userToCreateDto.Street,
            PostalCode = userToCreateDto.PostalCode,
            City = userToCreateDto.City,
            Country = userToCreateDto.Country
        };
        
        _dbContext.Users.Add(user);
        _dbContext.SaveChanges();
    }
}