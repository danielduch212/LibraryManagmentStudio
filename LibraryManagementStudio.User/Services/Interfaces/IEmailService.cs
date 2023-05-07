namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IEmailService
{
    void SendReturnCodeMessage(string toEmailAddress, string returnCode, string bookName);
}