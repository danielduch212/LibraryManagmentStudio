using LibraryManagementStudio.Data;
using LibraryManagementStudio.User.Dtos.User;
using LibraryManagementStudio.User.Services.Interfaces;

namespace LibraryManagementStudio.User.Services;

public class UserAuthService : IUserAuthService
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
    
    public UserDto? ValidateCredentials(string emailAddress, string password)
    {
        var user = _dbContext.Users.FirstOrDefault(x => x.EmailAddress.ToLower() == emailAddress.ToLower());
        
        if (user == null)
        {
            return null;
        }

        var verifyPassword = PasswordHelper.VerifyPassword(password, user.Password);

        if (!verifyPassword)
        {
            return null;
        }
        
        var userDto = new UserDto()
        {
            UserId = user.UserId,
            FirstName = user.FirstName,
            LastName = user.LastName,
            EmailAddress = user.EmailAddress,
            DateOfBirth = user.DateOfBirth,
            Street = user.Street,
            PostalCode = user.PostalCode,
            City = user.City,
            Country = user.Country,
            CreationDate = user.CreationDate
        };

        return userDto;
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