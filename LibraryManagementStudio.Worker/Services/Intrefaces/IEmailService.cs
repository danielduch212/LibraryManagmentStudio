namespace LibraryManagementStudio.Worker.Services.Intrefaces;

public interface IEmailService
{
    void SendPickupCodeMessage(string toEmailAddress, string pickupCode, string bookName);
}