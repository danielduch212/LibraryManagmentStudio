using Microsoft.EntityFrameworkCore;

namespace LibraryManagementStudio.Data.Seeders;

public class LibrarySeeder
{
    private LibraryDbContext _dbContext;

    public LibrarySeeder()
    {
        _dbContext = new LibraryDbContext();
    }

    public void SeedDatabase()
    {
        if (!_dbContext.Database.CanConnect()) 
            return;

        //Check if database is already seeded
        if (_dbContext.Books.Any() || _dbContext.Authors.Any() || _dbContext.Publishers.Any() 
            || _dbContext.BookCopies.Any() || _dbContext.Workers.Any())
        {
            return;
        }
        
        HandleDatabaseSeed();
    }

    private void HandleDatabaseSeed()
    {
        _dbContext.Database.OpenConnection();
        
        try
        {
            //Seed Authors
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.AuthorsIdentityInsertEnabled);
            SeedAuthors();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.AuthorsIdentityInsertDisabled);

            //Seed Publishers
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.PublishersIdentityInsertEnabled);
            SeedPublishers();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.PublishersIdentityInsertDisabled);

            //Seed Workers
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.WorkersIdentityInsertEnabled);
            SeedWorkers();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.WorkersIdentityInsertDisabled);

            //Seed Books
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BooksIdentityInsertEnabled);
            SeedBooks();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BooksIdentityInsertDisabled);

            //Seed BookCopies
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BookCopiesIdentityInsertEnabled);
            SeedBookCopies();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BookCopiesIdentityInsertDisabled);
        }
        finally
        {
            _dbContext.Database.CloseConnection();
        }
    }
    
    private void SeedAuthors()
    {
        var authors = DummyDataProvider.GetDummyAuthors();

        _dbContext.Authors.AddRange(authors);
        _dbContext.SaveChanges();
    }
    
    private void SeedPublishers()
    {
        var publishers = DummyDataProvider.GetDummyPublishers();

        _dbContext.Publishers.AddRange(publishers);
        _dbContext.SaveChanges();
    }
    
    private void SeedWorkers()
    {
        var workers = DummyDataProvider.GetDummyWorkers();

        _dbContext.Workers.AddRange(workers);
        _dbContext.SaveChanges();
    }

    private void SeedBooks()
    {
        var books = DummyDataProvider.GetDummyBooks();

        _dbContext.Books.AddRange(books);
        _dbContext.SaveChanges();
    }
    
    private void SeedBookCopies()
    {
        var bookCopies = DummyDataProvider.GetDummyBookCopies();

        _dbContext.BookCopies.AddRange(bookCopies);
        _dbContext.SaveChanges();
    }
}