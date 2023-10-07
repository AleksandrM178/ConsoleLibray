using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibray.Core.Models
{
    public class Library
    {
        public string Name { get; set; }
        public int BookCount { get; set; }

        public Library(string name, int bookCount)
        { 
            Name = name;
            BookCount = bookCount;
        }
    }
}
