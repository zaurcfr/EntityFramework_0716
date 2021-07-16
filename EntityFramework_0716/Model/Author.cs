using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0716.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
