using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string name;
        public string author;
        public int pages;

        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;

        }
    }
}
