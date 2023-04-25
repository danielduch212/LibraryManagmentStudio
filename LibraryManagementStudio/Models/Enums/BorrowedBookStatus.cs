using System.ComponentModel;

namespace LibraryManagementStudio.Models.Enums;

public enum BorrowedBookStatus
{
    [Description("Oczekiwanie")]
    Requested,
    
    [Description("Gotowa do odbioru")]
    ReadyForPickup,
    
    [Description("Odebrana")]
    Received,
    
    [Description("Gotowa do zwrotu")]
    ReadyForReturn,
    
    [Description("Zwrócona")]
    Returned
}