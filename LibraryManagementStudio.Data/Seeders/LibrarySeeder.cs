using LibraryManagementStudio.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementStudio.Data.Seeders;

public class LibrarySeeder
{
    private LibraryDbContext _dbContext;
    DummyDataProvider dummyDataProvider = new DummyDataProvider();
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
            
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.UsersIdentityInsertEnabled);
            SeedUsers();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.UsersIdentityInsertDisabled);

            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BookBorrowsIdentityInsertEnabled);
            SeedBookBorrows();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.BookBorrowsIdentityInsertDisabled);

            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.PenaltiesIdentityInsertEnabled);
            SeedPenalties();
            _dbContext.Database.ExecuteSqlRaw(IdentityInsertCommands.PenaltiesIdentityInsertDisabled);


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

    private void SeedUsers()
    {
        var users = DummyDataProvider.GetDummyUsers();

        _dbContext.Users.AddRange(users);
        _dbContext.SaveChanges();
    }

    private void SeedBookBorrows()
    {
        
        var bookBorrows = dummyDataProvider.GetDummyBookBorrows();
        _dbContext.BookBorrows.AddRange(bookBorrows);
        _dbContext.SaveChanges();

    }

    private void SeedPenalties()
    {
        
        var penalties = dummyDataProvider.GetDummyPenalties();
        _dbContext.Penalties.AddRange(penalties);
        _dbContext.SaveChanges();

    }
}