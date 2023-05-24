using LibraryManagementStudio.Data;
using LibraryManagementStudio.Worker.Views.AdminView;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementStudio.Worker.Services
{
    public class PublisherAuthorService
    {
        private readonly LibraryDbContext _dbContext;

        public PublisherAuthorService(LibraryDbContext _dbContext)
        {
            this._dbContext = _dbContext;

        }
        public IEnumerable<LibraryManagementStudio.Data.Models.Publisher> GetPublishers()
        {

            var query = _dbContext.Publishers
           .Select(x => new LibraryManagementStudio.Data.Models.Publisher()
           {
             Name = x.Name,

           });

            var publishers = query.ToList();

            return publishers;
        }

        public IEnumerable<LibraryManagementStudio.Data.Models.Author> GetAuthors()
        {

            var query = _dbContext.Authors
           .Select(x => new LibraryManagementStudio.Data.Models.Author()
           {
               Name = x.Name,

           });

            var authors = query.ToList();

            return authors;
        }

        public void AddAuthor(string name)
        {
            LibraryManagementStudio.Data.Models.Author author = new Data.Models.Author()
            {
                Name = name,
            };
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();

        }
        public void AddPublisher(string name)
        {
            LibraryManagementStudio.Data.Models.Publisher publisher = new Data.Models.Publisher()
            {
                Name = name,
            };
            _dbContext.Publishers.Add(publisher);
            _dbContext.SaveChanges();

        }

        public LibraryManagementStudio.Data.Models.Publisher GetPublisher(string name)
        {
            var query = _dbContext.Publishers
               .FirstOrDefault(x => x.Name.Equals(name));
            return query;

        }

        public LibraryManagementStudio.Data.Models.Author GetAuthor(string name)
        {
            var query = _dbContext.Authors
               .FirstOrDefault(x => x.Name.Equals(name));
            return query;

        }

        public IEnumerable<string> getAuthorsNames()
        {
            var authors = GetAuthors();
            List<string> authorsNames = new List<string>();
            foreach (LibraryManagementStudio.Data.Models.Author author in authors)
            {
                authorsNames.Add(author.Name);
            }
            return authorsNames;
        }

        public IEnumerable<string> getPublishersNames()
        {
            var publishers = GetPublishers();
            List<string> publishersNames = new List<string>();
            foreach (LibraryManagementStudio.Data.Models.Publisher publisher in publishers)
            {
                publishersNames.Add(publisher.Name);
            }
            return publishersNames;
        }
    }
}
