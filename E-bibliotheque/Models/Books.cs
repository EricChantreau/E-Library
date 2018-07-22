using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_librairy.Models
{
    public class Database
    {
        public static List<Author> Authors { get; private set; }
        public static List<Book> Books { get; private set; }
        public static List<Client> Clients { get; private set; }

        public static void InitDatabase()
        {
            Authors = new List<Author>
            {
                new Author { Id = 1, Name = "Author 1" },
                new Author { Id = 2, Name = "Author 2" },
                new Author { Id = 3, Name = "Author 3" },
            };
            Clients = new List<Client>
            {
                new Client { Name = "Client 1", Email = "client1@gmail.com" },
                new Client { Name = "Client 2", Email = "client2@gmail.com" },
            };
            Books = new List<Book>
            {
                new Book { Id = 1, Title = "Book 1", PublishedAt = DateTime.Parse("2017-02-05"), Author = Authors[0] },
                new Book { Id = 2, Title = "Book 2", PublishedAt = DateTime.Parse("2014-05-22"), Author = Authors[0], Client = Clients[0] },
                new Book { Id = 3, Title = "Book 3", PublishedAt = DateTime.Parse("2018-07-03"), Author = Authors[1], Client = Clients[0] },
                new Book { Id = 4, Title = "Book 4", PublishedAt = DateTime.Parse("2010-12-25"), Author = Authors[1] },
                new Book { Id = 5, Title = "Book 5", PublishedAt = DateTime.Parse("1999-01-01"), Author = Authors[2], Client = Clients[1] },
            };
        }
    }
}