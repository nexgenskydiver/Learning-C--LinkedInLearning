using System;

namespace Defining
{
    // Classes have a name, unique within the namespace
    public class Book
    {
        // Classes have member variables, or "fields" to hold datas
        string _name;
        string _author;
        int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}