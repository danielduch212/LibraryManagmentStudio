using LibraryManagementStudio.Models;
using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Seeders;

public static class DummyDataProvider
{
    public static IEnumerable<Worker> GetDummyWorkers()
    {
        var workers = new List<Worker>
        {
            new()
            {
                WorkerId = 1,
                FirstName = "Adam",
                LastName = "Nelson",
                EmailAddress = "bibliotekarz@gmail.com",
                Password = "1234",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 2,
                FirstName = "John",
                LastName = "Nelson",
                EmailAddress = "obsluga@gmail.com",
                Password = "1234",
                Type = WorkerType.obsługa
            }
        };

        return workers;
    }
    
    public static IEnumerable<Author> GetDummyAuthors()
    {
        var authors = new List<Author>
        {
            new()
            {
                AuthorId = 1,
                Name = "Jack Weatherford"
            }
        };

        return authors;
    }

    public static IEnumerable<Publisher> GetDummyPublishers()
    {
        var publishers = new List<Publisher>
        {
            new()
            {
                PublisherId = 1,
                Name = "Crown and Three Rivers Press"
            }
        };

        return publishers;
    }
    
    public static IEnumerable<Book> GetDummyBooks()
    {
        var books = new List<Book>()
        {
            new()
            {
                BookId = 1,
                Title = "Genghis Khan i tworzenie Nowego Świata",
                Description = "Książka opisuje zachodnie przedstawienie Mongołów jako dzikusów, którzy zniszczyli cywilizację i sugeruje, że było to błędne. Autor książek, dla których ważne było panowanie mongolskie, np.: lżejsze podatki, tolerancja dla lokalnych zwyczajów i religii.",
                PublishDate = new DateTime(2004, 1, 1),
                Category = CategoryType.History,
                AuthorId = 1,
                PublisherId = 1,
                WorkerId = 1,
            },
            new()
            {
                BookId = 2,
                Title = "Piękny umysł",
                Description = "W wieku 21 lat John Nash opublikował pracę doktorską, w której sformułował \"teorię równowagi Nasha\" - nowe rewolucyjne podejście do kluczowego problemu teorii gier niezespołowych, opisujące mechanizmy racjonalnego zachowania człowieka. Kilkanaście lat później jego wynik dokonał przewrotu we współczesnej ekonomii, co doceniono przyznając matematykowi Nagrodę Nobla w 1994 roku.",
                PublishDate = new DateTime(2002, 1, 1),
                Category = CategoryType.History,
                AuthorId = 1,
                PublisherId = 1,
                WorkerId = 1,
            }
        };

        return books;
    }
    
    public static IEnumerable<BookCopy> GetDummyBookCopies()
    {
        var bookCopies = new List<BookCopy>()
        {
            new()
            {
                BookCopyId = 1,
                IsAvailable = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 2,
                IsAvailable = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 3,
                IsAvailable = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 4,
                IsAvailable = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 1
            },
            new()
            {
                BookCopyId = 5,
                IsAvailable = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 1
            },
            new()
            {
                BookCopyId = 6,
                IsAvailable = true,
                Status = BookCopyStatus.dobry,
                BookId = 2
            },
            new()
            {
                BookCopyId = 7,
                IsAvailable = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 2
            },
        };

        return bookCopies;
    }
}