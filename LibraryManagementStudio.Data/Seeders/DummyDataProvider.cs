using LibraryManagementStudio.Data.Models;
using LibraryManagementStudio.Data.Models.Enums;
using LibraryManagementStudio.Data;

using System.Diagnostics.Metrics;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LibraryManagementStudio.Data.Seeders;





public class DummyDataProvider
{

    
    private User findUser(int id)
    {
        LibraryDbContext db = new LibraryDbContext();
        var query = db.Users
                .FirstOrDefault(x => x.UserId.Equals(id));
        return query;
    }

    private BookCopy findBookCopy(int id)
    {
        LibraryDbContext db = new LibraryDbContext();
        var query = db.BookCopies
                .FirstOrDefault(x => x.BookCopyId.Equals(id));
        return query;
    }
    private BookBorrow findBookBorrow(int id)
    {
        LibraryDbContext db = new LibraryDbContext();
        var query = db.BookBorrows
                .FirstOrDefault(x => x.BookBorrowId.Equals(id));
        return query;
    }

    private Worker findWorker(int id)
    {
        LibraryDbContext db = new LibraryDbContext();
        var query = db.Workers
                .FirstOrDefault(x => x.WorkerId.Equals(id));
        return query;

    }

    public static IEnumerable<User> GetDummyUsers()
    {

       
        var users = new List<User>
        {
            new()
            {
                UserId = 1,
                EmailAddress = "andziaks@gmail.com",
                Password = PasswordHelper.HashPassword("1234"),
                FirstName = "Angelika",
                LastName = "Angelika",
                DateOfBirth = new DateTime(2004, 1, 1),
                Street = "Hybrydowa",
                PostalCode = "43-300",
                City = "Bielsko",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 2,
                EmailAddress = "daniel@gmail.com",
                Password = PasswordHelper.HashPassword("daniel"),
                FirstName = "Daniel",
                LastName = "Cebulowy",
                DateOfBirth = new DateTime(2004, 1, 1),
                Street = "Niegrozna",
                PostalCode = "40-907",
                City = "Bytom",
                Country = "Polska",
                CreationDate = DateTime.Now,

            },
            new()
            {
                UserId = 3,
                EmailAddress = "kamil@gmail.com",
                Password = PasswordHelper.HashPassword("qwerty"),
                FirstName = "Kamil",
                LastName = "Kowalski",
                DateOfBirth = new DateTime(1995, 5, 10),
                Street = "Główna",
                PostalCode = "12-345",
                City = "Warszawa",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 4,
                EmailAddress = "magda@gmail.com",
                Password = PasswordHelper.HashPassword("password123"),
                FirstName = "Magdalena",
                LastName = "Nowak",
                DateOfBirth = new DateTime(1990, 3, 15),
                Street = "Kwiatowa",
                PostalCode = "54-321",
                City = "Kraków",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 5,
                EmailAddress = "adam@gmail.com",
                Password = PasswordHelper.HashPassword("pass123"),
                FirstName = "Adam",
                LastName = "Adamowski",
                DateOfBirth = new DateTime(1988, 12, 1),
                Street = "Słoneczna",
                PostalCode = "67-890",
                City = "Gdańsk",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 6,
                EmailAddress = "ewa@gmail.com",
                Password = PasswordHelper.HashPassword("password"),
                FirstName = "Ewa",
                LastName = "Ewowska",
                DateOfBirth = new DateTime(1992, 8, 20),
                Street = "Brzozowa",
                PostalCode = "87-654",
                City = "Poznań",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 7,
                EmailAddress = "marek@gmail.com",
                Password = PasswordHelper.HashPassword("test123"),
                FirstName = "Marek",
                LastName = "Marecki",
                DateOfBirth = new DateTime(1985, 6, 5),
                Street = "Kościelna",
                PostalCode = "32-100",
                City = "Kielce",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 8,
                EmailAddress = "Ola@gmail.com",
                Password = PasswordHelper.HashPassword("Ola"),
                FirstName = "Ola",
                LastName = "Barczyk",
                DateOfBirth = new DateTime(1997, 9, 25),
                Street = "Lipowa",
                PostalCode = "58-900",
                City = "Wrocław",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 9,
                EmailAddress = "KryNap@gmail.com",
                Password = PasswordHelper.HashPassword("KryNap"),
                FirstName = "Krystian",
                LastName = "Napierła",
                DateOfBirth = new DateTime(1993, 4, 12),
                Street = "Akacjowa",
                PostalCode = "09-876",
                City = "Łódź",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 10,
                EmailAddress = "anna@gmail.com",
                Password = PasswordHelper.HashPassword("anna123"),
                FirstName = "Anna",
                LastName = "Annowska",
                DateOfBirth = new DateTime(1998, 11, 8),
                Street = "Świerkowa",
                PostalCode = "23-456",
                City = "Szczecin",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 11,
                EmailAddress = "marcin@gmail.com",
                Password = PasswordHelper.HashPassword("marcinpass"),
                FirstName = "Marcin",
                LastName = "Kowalski",
                DateOfBirth = new DateTime(1990, 5, 20),
                Street = "Krótka",
                PostalCode = "12-345",
                City = "Warszawa",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 12,
                EmailAddress = "anna@gmail.com",
                Password = PasswordHelper.HashPassword("annapass"),
                FirstName = "Anna",
                LastName = "Nowak",
                DateOfBirth = new DateTime(1995, 8, 15),
                Street = "Długa",
                PostalCode = "54-321",
                City = "Kraków",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 13,
                EmailAddress = "piotr@gmail.com",
                Password = PasswordHelper.HashPassword("piotr123"),
                FirstName = "Piotr",
                LastName = "Kowalczyk",
                DateOfBirth = new DateTime(1988, 12, 1),
                Street = "Słoneczna",
                PostalCode = "67-890",
                City = "Gdańsk",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 14,
                EmailAddress = "agata@gmail.com",
                Password = PasswordHelper.HashPassword("agatapass"),
                FirstName = "Agata",
                LastName = "Wójcik",
                DateOfBirth = new DateTime(1992, 6, 25),
                Street = "Kwiatowa",
                PostalCode = "87-654",
                City = "Poznań",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 15,
                EmailAddress = "michał@gmail.com",
                Password = PasswordHelper.HashPassword("michalpass"),
                FirstName = "Michał",
                LastName = "Marecki",
                DateOfBirth = new DateTime(1985, 3, 5),
                Street = "Kościelna",
                PostalCode = "32-100",
                City = "Kielce",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 16,
                EmailAddress = "elżbieta@gmail.com",
                Password = PasswordHelper.HashPassword("elzbietapass"),
                FirstName = "Elżbieta",
                LastName = "Zielińska",
                DateOfBirth = new DateTime(1997, 9, 10),
                Street = "Lipowa",
                PostalCode = "58-900",
                City = "Wrocław",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 17,
                EmailAddress = "adam@gmail.com",
                Password = PasswordHelper.HashPassword("adampass"),
                FirstName = "Adam",
                LastName = "Piotrowski",
                DateOfBirth = new DateTime(1993, 4, 12),
                Street = "Akacjowa",
                PostalCode = "09-876",
                City = "Łódź",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 18,
                EmailAddress = "karolina@gmail.com",
                Password = PasswordHelper.HashPassword("karolinapass"),
                FirstName = "Karolina",
                LastName = "Dąbrowska",
                DateOfBirth = new DateTime(1989, 11, 8),
                Street = "Świerkowa",
                PostalCode = "23-456",
                City = "Szczecin",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 19,
                EmailAddress = "robert@gmail.com",
                Password = PasswordHelper.HashPassword("robertpass"),
                FirstName = "Robert",
                LastName = "Jankowski",
                DateOfBirth = new DateTime(1994, 2, 18),
                Street = "Akademicka",
                PostalCode = "55-444",
                City = "Opole",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
            new()
            {
                UserId = 20,
                EmailAddress = "natalia@gmail.com",
                Password = PasswordHelper.HashPassword("nataliapass"),
                FirstName = "Natalia",
                LastName = "Kaczmarek",
                DateOfBirth = new DateTime(1991, 7, 22),
                Street = "Szkolna",
                PostalCode = "12-678",
                City = "Gdynia",
                Country = "Polska",
                CreationDate = DateTime.Now,
            },
        };

        return users;
    }


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
            },
            new()
            {
                WorkerId = 3,
                FirstName = "admin",
                LastName = "admin",
                EmailAddress = "admin",
                Password = "admin",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 4,
                FirstName = "Katarzyna",
                LastName = "Nowak",
                EmailAddress = "kasia@gmail.com",
                Password = "hasło123",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 5,
                FirstName = "Michał",
                LastName = "Kowalski",
                EmailAddress = "michal@gmail.com",
                Password = "pass123",
                Type = WorkerType.obsługa
            },
            new()
            {
                WorkerId = 6,
                FirstName = "Robert",
                LastName = "Makłowicz",
                EmailAddress = "Robert@gmail.com",
                Password = "Robert",
                Type = WorkerType.obsługa
            },
            new()
            {
                WorkerId = 7,
                FirstName = "Jakub",
                LastName = "Wójcik",
                EmailAddress = "jakub@gmail.com",
                Password = "jakubpass",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 8,
                FirstName = "Iga",
                LastName = "Świątek",
                EmailAddress = "Paletka@gmail.com",
                Password = "Paletka",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 9,
                FirstName = "Robert",
                LastName = "Lewandowski",
                EmailAddress = "RobertRL9@gmail.com",
                Password = "RobertRL9",
                Type = WorkerType.bibliotekarz
            },
            new()
            {
                WorkerId = 10,
                FirstName = "Oliwia",
                LastName = "Szymańska",
                EmailAddress = "oliwia@gmail.com",
                Password = "oliwia123",
                Type = WorkerType.obsługa
            },

        };

        return workers;
    }
    
    public static IEnumerable<Author> GetDummyAuthors()
    {
        var authors = new List<Author>
        {
            new ()
            {
                AuthorId = 1,
                Name = "Jack Weatherford"
            },
            new()
            {
                AuthorId = 2,
                Name = "Hamilton Peter F."
            },
            new()
            {
                AuthorId = 3,
                Name = "Baxter Stephen"
            },
            new()
            {
                AuthorId = 4,
                Name = "Filippi Denis-Pierre,Cucca Vincenzo"
            },
            new()
            {
                AuthorId = 5,
                Name = "Dinie Michael"
            },
            new()
            {
                AuthorId = 6,
                Name = "Herbert G.Wells"
            },
            new()
            {
                AuthorId = 7,
                Name = "Crichton Micheal"
            },
            new()
            {
                AuthorId = 8,
                Name = "Anna Langne"
            },
            new()
            {
                AuthorId = 9,
                Name = "Glukhovsky Dmitry"
            },
            new()
            {
                AuthorId = 10,
                Name = "Roman Brandstaetter"
            },
            new()
            {
                AuthorId = 11,
                Name = "Robert Graves"
            },
            new()
            {
                AuthorId = 12,
                Name = "Tony Judt"
            },
            new()
            {
                AuthorId = 13,
                Name = "Norman Davies"
            },
            new()
            {
                AuthorId = 14,
                Name = "Heather Morris"
            },
            new()
            {
                AuthorId = 15,
                Name = "Swietłana Aleksijewicz"
            },
            new()
            {
                AuthorId = 16,
                Name = "Helena Zakrzewska"
            },
            new()
            {
                AuthorId = 17,
                Name = "Bogusław Wołoszański"
            },
            new()
            {
                AuthorId = 18,
                Name = "Henryk Sienkiewicz"
            },
            new()
            {
                AuthorId = 19,
                Name = "Andre Aciman"
            },
            new()
            {
                AuthorId = 20,
                Name = "Diana Gabaldon"
            },
            new()
            {
                AuthorId = 21,
                Name = "John Greenl"
            },
            new()
            {
                AuthorId = 22,
                Name = "Katarzyna Bester"
            },
            new()
            {
                AuthorId = 23,
                Name = "Cecelia Ahern"
            },
            new()
            {
                AuthorId = 24,
                Name = "Nicholas Spark"
            },


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
            },
            new()
            {
                PublisherId = 2,
                Name = "PWN",
            },

            new()
            {
                PublisherId = 3,
                Name = "Wydawnictwo Kobiece",
            },
            new()
            {
                PublisherId = 4,
                Name = "Wydawnictwo Insignis",
            },
            new()
            {
                PublisherId = 5,
                Name = "Wydawnictwo Zysk i S-ka",
            },
            new()
            {
                PublisherId = 6,
                Name = "Union-Verlag",
            },
            new()
            {
                PublisherId = 7,
                Name = "Arthur Baker",
            },
            new()
            {
                PublisherId = 8,
                Name = "Rebis",
            },
            new()
            {
                PublisherId = 9,
                Name = "Macmillian Publishers",
            },
            new()
            {
                PublisherId = 10,
                Name = "Paperback",
            },
            new()
            {
                PublisherId = 11,
                Name = "Ostoże",
            },
            new()
            {
                PublisherId = 12,
                Name = "Wydawnictwo LTW",
            },
            new()
            {
                PublisherId = 13,
                Name = "Wołoszański",
            },
            new()
            {
                PublisherId = 14,
                Name = "Dzienniki Polskie",
            },
            new()
            {
                PublisherId = 15,
                Name = "Farrar, Straus and Giroux",
            },
            new()
            {
                PublisherId = 16,
                Name = "Świat Książki",
            },
            new()
            {
                PublisherId = 17,
                Name = "John Green",
            },
            new()
            {
                PublisherId = 18,
                Name = "MUZA",
            },
            new()
            {
                PublisherId = 19,
                Name = "Książki Warnera",
            },


        };

        return publishers;
    }


    public IEnumerable<BookBorrow> GetDummyBookBorrows()
    {
        var bookBorrows = new List<BookBorrow>()
        {    
            // Wypożyczenie 1 Daniel copy 10
            new()
            {
                BookBorrowId = 1,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 2,
                User = findUser(2),
                BookCopyId = 10,
                BookCopy = findBookCopy(10),

            },
            // Wypożyczenie 2 Daniel copy 11
            new()
            {

                BookBorrowId = 2,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 2,
                User = findUser(2),
                BookCopyId = 11,
                BookCopy = findBookCopy(11),

            },

            // Wypożyczenie 3 Daniel copy 12
            new()
            {
                BookBorrowId = 3,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 2,
                User = findUser(2),
                BookCopyId = 12,
                BookCopy = findBookCopy(12),

            },
            // Wypożyczenie 4 Daniel copy 21
            new()
            {
                BookBorrowId = 4,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 2,
                User = findUser(2),
                BookCopyId = 21,
                BookCopy = findBookCopy(21),

            },
            // Wypożyczenie 5 Daniel copy 25
            new()
            {
                BookBorrowId = 5,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 2,
                User = findUser(2),
                BookCopyId = 25,
                BookCopy = findBookCopy(25),

            },
            // Wypożyczenie 6 Ola copy 26
            new()
            {
                BookBorrowId = 6,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 8,
                User = findUser(8),
                BookCopyId = 26,
                BookCopy = findBookCopy(26),

            },
            // Wypożyczenie 7 Ola copy 11
            new()
            {
                BookBorrowId = 7,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Requested,
                UserId = 8,
                User = findUser(8),
                BookCopyId = 11,
                BookCopy = findBookCopy(11),

            },
            // Wypożyczenie 8 Ola copy 8
            new()
            {
                BookBorrowId = 8,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.ReadyForPickup,
                UserId = 8,
                User = findUser(8),
                BookCopyId = 8,
                BookCopy = findBookCopy(8),

            },
            // Wypożyczenie 9 Ola copy 19
            new()
            {
                BookBorrowId = 9,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Returned,
                UserId = 8,
                User = findUser(8),
                BookCopyId = 19,
                BookCopy = findBookCopy(19),

            },
            // Wypożyczenie 10 KryNap copy 55
            new()
            {
                BookBorrowId = 10,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.ReadyForReturn,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 55,
                BookCopy = findBookCopy(55),

            },
            // Wypożyczenie 11 KryNap copy 33
            new()
            {
                BookBorrowId = 11,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Requested,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 33,
                BookCopy = findBookCopy(33),

            },
            // Wypożyczenie 12 KryNap copy 22
            new()
            {
                BookBorrowId = 12,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Returned,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 22,
                BookCopy = findBookCopy(22),

            },
            // Wypożyczenie 13 KryNap copy 16
            new()
            {
                BookBorrowId = 13,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.ReadyForReturn,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 16,
                BookCopy = findBookCopy(16),

            },
            // Wypożyczenie 14 KryNap copy 27
            new()
            {
                BookBorrowId = 14,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 27,
                BookCopy = findBookCopy(27),

            },
            // Wypożyczenie 15 KryNap copy 49
            new()
            {
                BookBorrowId = 15,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 49,
                BookCopy = findBookCopy(49),

            },
            // Wypożyczenie 16 KryNap copy 39 obsługuje RL9
            new()
            {
                BookBorrowId = 16,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 39,
                BookCopy = findBookCopy(39),

            },
            // Wypożyczenie 17 KryNap copy 46 obsługuje RL9
            new()
            {
                BookBorrowId = 17,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 29,
                User = findUser(9),
                BookCopyId = 46,
                BookCopy = findBookCopy(46),

            },
            // Wypożyczenie 18 KryNap copy 48 obsługuje RL9
            new()
            {
                BookBorrowId = 18,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 48,
                BookCopy = findBookCopy(48),

            },
            // Wypożyczenie 19 KryNap copy 50 obsługuje RL9
            new()
            {
                BookBorrowId = 19,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 50,
                BookCopy = findBookCopy(50),

            },
            // Wypożyczenie 20 KryNap copy 34 obsługuje RL9
            new()
            {
                BookBorrowId = 20,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(7),
                IsActive = true,
                Status = BorrowedBookStatus.Received,
                UserId = 9,
                User = findUser(9),
                BookCopyId = 34,
                BookCopy = findBookCopy(34),

            },


        };

        return bookBorrows;
    }

    public IEnumerable<Penalty> GetDummyPenalties()
    {
        var bookBorrows = new List<Penalty>()
        {

            // Kara 1 dla wypożyczenia 1
            new()
            {

                PenaltyId = 1,
                Description = "Przekroczenie terminu",
                Price = 10.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 1,
                BookBorrow = findBookBorrow(1),
                WorkerId = 1,
                Worker = findWorker(1),

            },

            // Kara 2 dla wypożyczenia 9 Makłowicz
            new()
            {

                PenaltyId = 2,
                Description = "Uszkodzenie okładki",
                Price = 15.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 9,
                BookBorrow = findBookBorrow(9),
                WorkerId = 6,
                Worker = findWorker(6),

            },
            // Kara 3 dla wypożyczenia 10 Makłowicz
            new()
            {

                PenaltyId = 3,
                Description = "Porysowana okładka",
                Price = 19.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 10,
                BookBorrow = findBookBorrow(10),
                WorkerId = 6,
                Worker = findWorker(6),

            },
            // Kara 4 dla wypożyczenia 11 Paletka
            new()
            {

                PenaltyId = 4,
                Description = "Plamy na stronach, oraz wgnieciona okładka",
                Price = 32.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 11,
                BookBorrow = findBookBorrow(11),
                WorkerId = 8,
                Worker = findWorker(8),

            },
            // Kara 5 dla wypożyczenia 12 Paletka
            new()
            {

                PenaltyId = 5,
                Description = "Zagięte strony i przecięte strony",
                Price = 50.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 12,
                BookBorrow = findBookBorrow(12),
                WorkerId = 8,
                Worker = findWorker(8),

            },
            // Kara 6 dla wypożyczenia 16 RL9
            new()
            {

                PenaltyId = 6,
                Description = "Wyszczerbione krawędzie stron",
                Price = 23.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 16,
                BookBorrow = findBookBorrow(16),
                WorkerId = 9,
                Worker = findWorker(9),

            },
            // Kara 7 dla wypożyczenia 17 RL9
            new()
            {

                PenaltyId = 7,
                Description = "Zniszczone boki książki oraz zaginione strony",
                Price = 78.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 17,
                BookBorrow = findBookBorrow(17),
                WorkerId = 9,
                Worker = findWorker(9),

            },
            // Kara 8 dla wypożyczenia 18 RL9
            new()
            {

                PenaltyId = 8,
                Description = "Rozlane płyny na okładce i plamy na stronach",
                Price = 34.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 18,
                BookBorrow = findBookBorrow(18),
                WorkerId = 9,
                Worker = findWorker(9),

            },
            // Kara 9 dla wypożyczenia 19 RL9
            new()
            {

                PenaltyId = 9,
                Description = "Zaginione strony oraz rozdarta okładka",
                Price = 54.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 19,
                BookBorrow = findBookBorrow(19),
                WorkerId = 9,
                Worker = findWorker(9),

            },
            // Kara 10 dla wypożyczenia 20 RL9
            new()
            {

                PenaltyId = 10,
                Description = "Pogniecione strony oraz poplamione strony",
                Price = 37.0,
                ImpositionDate = DateTime.Today.AddDays(7),
                IsPaid = false,
                BookBorrowId = 20,
                BookBorrow = findBookBorrow(20),
                WorkerId = 9,
                Worker = findWorker(9),

            },


        };

        return bookBorrows;
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
                IsActive = true,
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
                IsActive = true,
                AuthorId = 1,
                PublisherId = 1,
                WorkerId = 1,
            },

              new Book()
                {   BookId = 3,
                    Title = "Nie byłaś grzeczna w tym roku",
                    Description = "Gdy zbliżają się święta, przypadek sprawia, że Dorota i jej sąsiad poznają się w dość niemiłych okolicznościach. Kilkanaście dni później, mimo sprzeciwu obu stron, los ponownie pcha ich sobie w ramiona. Wygląda na to, że Boże Narodzenie będą musieli spędzić wspólnie. W powietrzu wisi katastrofa, ale kto wie, może uda się jej uniknąć? Przecież w święta wszystko jest możliwe.",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 8,
                    PublisherId = 3,
                    WorkerId = 1,
                },

                new Book()
                {
                    BookId = 4,
                    Title = "Outpost",
                    Description = "Historia Rosji praktycznie dobiegła kresu. Choć niektórzy usiłują nieporadnie dopisywać jej kolejne rozdziały, dla większości sprawa jest oczywista: to już koniec. Mimo że wciąż rodzą się dzieci, mimo że Jegor beznadziejnie zakochał się w Michelle, mimo że Pałkan nie ustaje w wydzwanianiu do Moskwy i błaganiu o uzupełnienie wyczerpujących się rezerw żywności… Tak, Rosji w zasadzie już nie ma; jej układ nerwowy – sieć połączeń transportowych i telekomunikacyjnych – został zerwany, zniszczony, a w najlepszym wypadku poważnie uszkodzony i nie wygląda na to, żeby zdołał się zregenerować",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 9,
                    PublisherId = 4,
                    WorkerId = 1,
                },
               new Book()
               {
                  BookId = 5,
                  Title = "Noc bez gwiazd",
                  Description = "Klasyczna międzygwiezdna przygoda w fascynującej opowieści o zbiegu, który niesie nadzieję ocalenia dla świata Wspólnoty.Przez stulecia więziona w Pustce, planeta Bienvenido wraz z jej mieszkańcami, zarówno ludźmi jak Upadłymi, została wyrzucona w zwykłą przestrzeń. Jednak ocaleni znajdują się miliony lat świetlnych od Wspólnoty, która nawet nie wie o ich istnieniu.",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 2,
                    PublisherId = 5,
                    WorkerId = 1,
               },
               new Book()
               {
                   BookId = 6,
                   Title="Jezus z Nazaretu",
                   Description="Opisane są miesiące konfliktu z faryzeuszami i nauczania. Także dramatyczne wydarzenia, takie jak ścięcie Jana Chrzciciela, aż po doskonałą ofiarę Jezusa na krzyżu.",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 10,
                    PublisherId = 6,
                    WorkerId = 1,
               },
               new Book()
               {
                   BookId = 7,
                   Title="Ja, Klaudiusz",
                   Description="Opowiadający swe losy Klaudiusz jest członkiem cesarskiej rodziny. Kuternoga i jąkała przystosowuje się do sytuacji udając głupca, dzięki czemu walcząca o władzę i mordująca się nawzajem rodzina pozostawia go przy życiu. Wydrwiwany i pogardzany przez wszystkich jest bystrym obserwatorem rzeczywistości i stosunków panujących na dworze cesarskim. Po morderstwie Kaliguli nieoczekiwanie Klaudiusz zostaje obwołany cezarem.",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 11,
                    PublisherId = 7,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 8,
                    Title="Powojnie.Historia Europy od roku 1945.",
                    Description="Powojnie przedstawia wspaniałe i skomplikowane dzieje, na które wciąż pada cień wojny. Opowiada o podnoszeniu się kontynentu z gruzów, o upadku radzieckiego komunizmu, powstaniu Wspólnot Europejskich i UE, o końcu imperiów kolonialnych oraz niełatwym i zmieniającym się stosunku do związanych z Europą supermocarstw: Rosji i Ameryki.",
                    PublishDate = new DateTime(2014, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 12,
                    PublisherId = 8,
                    WorkerId = 1,
               },
               new Book()
               {
                   BookId = 9,
                   Title="Powstanie `44",
                   Description="Powstanie Warszawskie to jedno z najbardziej dramatycznych wydarzeń drugiej wojny światowej, w którym ogniskują się historyczne konflikty tamtego czasu. Chociaż z różnych powodów na Zachodzie i na Wschodzie starano się o Powstaniu zapomnieć - jego skutki były trwałe, a jego echa brzmią po dzień dzisiejszy. Historyczne znaczenie Powstania w związku z siłami działającymi w obrębie antyhitlerowskiej koalicji lepiej widać dziś, z perspektywy czasu.",
                    PublishDate = new DateTime(2003, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 13,
                    PublisherId = 9,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 10,
                    Title="Tatuażysta z Auschwitz",
                    Description="Prawdziwa historia Lalego Sokolowa, który tatuowal numery na przedramionach wiezniów osadzonych w Auschwitz. Milczal przez ponad pól wieku, tuz przed smiercia zdecydowal sie opowiedziec swoje losy. Tatuazysta z Auschwitz to wlasnie opowiesc Sokolowa, która uslyszala i spisala autorka.\r\nLale Sokolow trafil do obozu w Auschwitz w 1942 roku. Mial wówczas dwadziescia szesc lat, znal kilka jezyków. Mial tatuowac numery na przedramionach przybywajacych do obozu wiezniów. Zadawac im ból i cierpienie, naznaczac na cale zycie. Dzieki swoim obowiazkom cieszyl sie w obozie wyjatkowa wolnoscia, mógl sie po nim przemieszczac z wieksza swoboda niz reszta osadzonych. Wykorzystal to, by pomagac innym.",
                    PublishDate = new DateTime(2018, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 14,
                    PublisherId = 10,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId =11,
                    Title="Krzyk Czarnobyla",
                    Description=" W czasie katastrofy (kwiecień 1986) Aleksijewicz był dziennikarzem mieszkającym w Mińsku , stolicy ówczesnej Białoruskiej Socjalistycznej Republiki Radzieckiej . Aleksijewicz przesłuchał ponad 500 naocznych świadków, w tym strażaków, likwidatorów(członków zespołu sprzątającego), polityków, lekarzy, fizyków i zwykłych obywateli przez okres 10 lat. Książka dotyczy psychologicznej i osobistej tragedii wypadku w Czarnobylu i bada doświadczenia poszczególnych osób oraz wpływ katastrofy na ich życie.",
                    PublishDate = new DateTime(1997, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 15,
                    PublisherId = 11,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 12,
                    Title="Dzieci Lwowa",
                    Description="Książkę tworzą dwie wzruszające i tchnące najczystszym patriotyzmem opowieści o małych mieszkańcach miasta, przez stulecia uważanego za ostoję polskości na kresach dawnej Rzeczypospolitej. Bohaterem pierwszej z owych historii jest chłopczyk, oderwany od rodzinnego domu przez zawieruchę Wielkiej Wojny i skazany na poniewierkę wśród obcych; akcja drugiej z nich dzieje się w roku 1918, kiedy to kilkoro nastoletnich lwowian bierze udział w obronie swego miasta przed siłami ukraińskimi. ",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 16,
                    PublisherId = 12,
                    WorkerId = 1,
                },
               new Book()
               {
                    BookId = 13,
                    Title="Twierdza Szyfrów",
                    Description="Tajemnica twierdzy szyfrów” to osadzona w realiach II wojny światowej bestsellerowa powieść Bogusława Wołoszańskiego pt. „Twierdza szyfrów”. 13-odcinkowy fabularny serial telewizyjny ze znakomitą obsadą w reżyserii Adka Drabińskiego. To wielkie historyczne widowisko, kino wojenne o wartkiej, trzymającej w napięciu akcji. Są tu efektowne sceny batalistyczne z udziałem m.in. artylerii przeciwlotniczej, owiana tajemnicą maszyna „ryba-miecz”, polski szpieg w niemieckim mundurze, walka wywiadów, splatające się wątki, dramatyczne wydarzenia rozgrywające się w mrocznych tunelach wraz z opisem Dolnego Śląska.",
                    PublishDate = new DateTime(2004, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 17,
                    PublisherId = 13,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 14,
                    Title="Quo Vadis",
                    Description="Powieść Quo vadis opowiada o miłości, jaka rozwija się między młodą chrześcijanką Ligią a rzymskim patrycjuszem Markiem Winicjuszem. Akcja rozgrywa się w Rzymie za panowania cesarza Nerona ok . 64 r ne",
                    PublishDate = new DateTime(1998, 1, 1),
                    Category = CategoryType.History,
                    IsActive = true,
                    AuthorId = 18,
                    PublisherId = 14,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 15,
                    Title="Tamte dni, tamte noce",
                    Description="Nastolatek Elio spędza wakacje we Włoszech, czytając i grając na pianinie. Jego ojca, uniwersyteckiego profesora, odwiedza pracujący nad doktoratem stypendysta, Amerykanin Oliver. Elio musi oddać gościowi swój własny pokój, jest więc do niego początkowo uprzedzony, uważa go za uzurpatora i aroganta. Ten stosunek z czasem ulega zmianie, pojawia się fascynacja mężczyzną, która przybiera na sile. ",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 19,
                    PublisherId = 15,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 16,
                    Title="Obca",
                    Description="\"Obca\" to pierwsza część bestsellerowego cyklu, którego autorką jest Diana Gabaldon. Niezwykła opowieść o Claire Randall, pielęgniarce, która właśnie powróciła z frontu II wojny światowej. Chcą odbudować swoje małżeństwo, kobieta wraz z mężem udaje się do Szkocji, gdzie dotyka pewnego niezwykłego i magicznego głazu, na skutek czego przenosi się do 1743 roku.",
                    PublishDate = new DateTime(2021, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 20,
                    PublisherId = 16,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 17,
                    Title="Gwiazd naszych wina",
                    Description="Książka opowiada historię szesnastoletniej Hazel chorującej na raka tarczycy. Jej nowotwór rozprzestrzenia się i przechodzi na płuca. W wyniku trudności z oddychaniem dziewczyna zmuszona jest do chodzenia wszędzie z butlą z tlenem. Pewnego dnia na jednym ze spotkań grupy wsparcia poznaje Augustusa Watersa",
                    PublishDate = new DateTime(2012, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 21,
                    PublisherId = 17,
                    WorkerId = 1,
               },
               new Book()
               {
                    BookId = 18,
                    Title="Świąteczne nieporozumienie",
                    Description="Holden przyjeżdża do Londynu w interesach. Ma tu zostać przez miesiąc, a później wrócić do spokojnego życia w Nowym Jorku, gdzie spędzi święta z rodziną. Wszystko jednak nieco się komplikuje, gdy na jego drodze staje pyskata Brytyjka, która uznaje go za włamywacza i wymierza mu cios parasolem. Między tą dwójką rodzi się niechęć, która szybko zmienia się w pożądanie.",
                    PublishDate = new DateTime(2020, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 22,
                    PublisherId = 3,
                    WorkerId = 1,
               },
               new Book()
               {
                   BookId = 19,
                   Title="Na końcu tęczy",
                   Description="Jako psotne dzieci i buntowniczy nastolatkowie, Rosie i Alex trwali przy sobie na dobre i na złe. Ledwie jednak zaczęli poznawać uroki nocnych wypadów na miasto i ból porażek miłosnych, zostali rozdzieleni. Rodzina Alexa przeprowadziła się z Dublina do Ameryki i Alex pojechał z nimi - na dobre. Rosie czuje się zagubiona bez swego przyjaciela, ale w przeddzień jej wyjazdu do Alexa, do Bostonu, dowiaduje się o czymś, co na zawsze zmieni jej życie… i zatrzyma ją w domu, w Irlandii.",
                    PublishDate = new DateTime(2013, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 23,
                    PublisherId = 18,
                    WorkerId = 1,
               },
               new Book()
               {
                   BookId = 20,
                   Title="List w butelce",
                   Description="Rozwiedziona i rozczarowana romantycznymi związkami Theresa Osborne podczas joggingu znajduje butelkę na plaży. Wewnątrz znajduje się list miłosny i należący do „Catherine”, podpisany po prostu „Garrett”. Wyzywana przez tajemnicę i targana emocjami, których nie do końca rozumie, Theresa rozpoczyna poszukiwania mężczyzny, który odmieni jej życie. To, co się z nią dzieje, jest nieoczekiwane, być może cudowne – spotkanie, które obejmuje wszystkie nasze nadzieje na znalezienie kogoś wyjątkowego, na prawdziwą i silną miłość, która jest ponadczasowa i wieczna.",
                    PublishDate = new DateTime(1998, 1, 1),
                    Category = CategoryType.Romance,
                    IsActive = true,
                    AuthorId = 24,
                    PublisherId = 19,
                    WorkerId = 1,
               },






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
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 2,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 3,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 1
            },
            new()
            {
                BookCopyId = 4,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 1
            },
            new()
            {
                BookCopyId = 5,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 1
            },
            new()
            {
                BookCopyId = 6,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 2
            },
            new()
            {
                BookCopyId = 7,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 2
            },
            new()
            {
                BookCopyId = 8,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 3
            },
            new()
            {
                BookCopyId = 9,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 3
            },
            new()
            {
                BookCopyId = 10,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 3
            },
            new()
            {
                BookCopyId = 11,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 4
            },
            new()
            {
                BookCopyId = 12,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 4
            },
            new()
            {
                BookCopyId = 13,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 4
            },
            new()
            {
                BookCopyId = 14,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 5
            },
            new()
            {
                BookCopyId = 15,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 5
            },
            new()
            {
                BookCopyId = 16,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 5
            },
            new()
            {
                BookCopyId = 17,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 6
            },
            new()
            {
                BookCopyId = 18,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 6
            },
            new()
            {
                BookCopyId = 19,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 6
            },
            new()
            {
                BookCopyId = 20,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 7
            },
            new()
            {
                BookCopyId = 21,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 7
            },
            new()
            {
                BookCopyId = 22,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 7
            },
            new()
            {
                BookCopyId = 23,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 8
            },
            new()
            {
                BookCopyId = 24,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 8
            },
            new()
            {
                BookCopyId = 25,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 8
            },
            new()
            {
                BookCopyId = 26,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 9
            },
            new()
            {
                BookCopyId = 27,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 9
            },
            new()
            {
                BookCopyId = 28,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 9
            },
            new()
            {
                BookCopyId = 29,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 10
            },
            new()
            {
                BookCopyId = 30,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 10
            },
            new()
            {
                BookCopyId = 31,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 10
            },
            new()
            {
                BookCopyId =32,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 11
            },
            new()
            {
                BookCopyId = 33,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 11
            },
            new()
            {
                BookCopyId = 34,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 11
            },
            new()
            {
                BookCopyId = 35,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 12
            },
            new()
            {
                BookCopyId = 36,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 12
            },
            new()
            {
                BookCopyId = 37,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 12
            },
            new()
            {
                BookCopyId = 38,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 13
            },
            new()
            {
                BookCopyId = 39,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 13
            },
            new()
            {
                BookCopyId = 40,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 13
            },            new()
            {
                BookCopyId = 41,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 14
            },
            new()
            {
                BookCopyId = 42,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 14
            },
            new()
            {
                BookCopyId = 43,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 14
            },
            new()
            {
                BookCopyId = 44,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 15
            },
            new()
            {
                BookCopyId = 45,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 15
            },
            new()
            {
                BookCopyId = 46,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 15
            },
            new()
            {
                BookCopyId = 47,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 16
            },
            new()
            {
                BookCopyId = 48,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 16
            },
            new()
            {
                BookCopyId = 49,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 16
            },
            new()
            {
                BookCopyId = 50,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 17
            },
            new()
            {
                BookCopyId = 51,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 17
            },
            new()
            {
                BookCopyId = 52,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 17
            },
            new()
            {
                BookCopyId = 53,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 18
            },
            new()
            {
                BookCopyId = 54,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 18
            },
            new()
            {
                BookCopyId = 55,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 18
            },            new()
            {
                BookCopyId = 56,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 19
            },
            new()
            {
                BookCopyId = 57,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 19
            },
            new()
            {
                BookCopyId = 58,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 19
            },
            new()
            {
                BookCopyId = 59,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 20
            },
            new()
            {
                BookCopyId = 60,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.dobry,
                BookId = 20
            },
            new()
            {
                BookCopyId = 61,
                IsAvailable = true,
                IsActive = true,
                Status = BookCopyStatus.uszkodzony,
                BookId = 20
            },


        };

        return bookCopies;
    }

    
}