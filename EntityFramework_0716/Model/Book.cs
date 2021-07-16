using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0716.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public int Pages { get; set; }
        public string Keyword { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
