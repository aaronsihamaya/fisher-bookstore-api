using System;
using System.Collections.Generic;

namespace Fisher.Bookstore.Api.Models
{
    public class Author
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string bio { get; set; }

        public List<Book> Titles { get; set; }
    }
}