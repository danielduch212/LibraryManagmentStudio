using LibraryManagementStudio.User.Dtos.User;

namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IUserAuthService
{
    bool FindUser(string emailAddress);
    UserDto? ValidateCredentials(string emailAddress, string password);
    void CreateUser(CreateUserDto userToCreateDto);
}