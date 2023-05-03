namespace LibraryManagementStudio.User.Services.Interfaces;

public interface IEmailService
{
    void SendCodeMessage(string toEmailAddress, string pickupCode, string returnCode, string bookName);
}