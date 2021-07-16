using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_0716.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime EstablishDate { get; set; }
        public List<Book> Books { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
