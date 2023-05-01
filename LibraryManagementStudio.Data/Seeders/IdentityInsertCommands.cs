namespace LibraryManagementStudio.Data.Seeders;

public class IdentityInsertCommands
{
    //Authors
    public const string AuthorsIdentityInsertEnabled = "SET IDENTITY_INSERT dbo.Authors ON";
    public const string AuthorsIdentityInsertDisabled = "SET IDENTITY_INSERT dbo.Authors OFF";
    
    //Publishers
    public const string PublishersIdentityInsertEnabled = "SET IDENTITY_INSERT dbo.Publishers ON";
    public const string PublishersIdentityInsertDisabled = "SET IDENTITY_INSERT dbo.Publishers OFF";
    
    //Workers
    public const string WorkersIdentityInsertEnabled = "SET IDENTITY_INSERT dbo.Workers ON";
    public const string WorkersIdentityInsertDisabled = "SET IDENTITY_INSERT dbo.Workers OFF";
    
    //Books
    public const string BooksIdentityInsertEnabled = "SET IDENTITY_INSERT dbo.Books ON";
    public const string BooksIdentityInsertDisabled = "SET IDENTITY_INSERT dbo.Books OFF";
    
    //BookCopies
    public const string BookCopiesIdentityInsertEnabled = "SET IDENTITY_INSERT dbo.BookCopies ON";
    public const string BookCopiesIdentityInsertDisabled = "SET IDENTITY_INSERT dbo.BookCopies OFF";
}