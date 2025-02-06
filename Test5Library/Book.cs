using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5Library
{
    class Book
    {
        private string title;
        private int year;
        private List<string> authors; //
        public Book(string title, int year, List<string> authors) //
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors; 
        }
        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public int Year
        {
            get { return year; }
            private set { year = value; }
        }

        public IReadOnlyList<string> Authors { get; private set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year} Authors: {string.Join(", ", this.Authors)}";
        }


    }
}
