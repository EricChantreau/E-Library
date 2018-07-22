using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_librairy.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public Author Author { get; set; }
        public Client Client { get; set; }
    }
}