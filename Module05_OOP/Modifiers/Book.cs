using System;

namespace Modifiers
{
    // Access modifiers control how properties and methods are accessed
    class Book
    {
        // PUBLIC members and methods can be accessed by any other code
        // Note: this is *NOT* the right way to expose internal data
        public string _name;

        // PROTECTED members can only be accessed by the class or a
        // derived class from this one
        protected string _author;

        // PRIVATE is the default and can only be accessed by code
        // within the class itself
        private int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string GetDescription()
        {
            return $"{_name} by {_author}, {_pagecount} pages";
        }

        // Member variables can be accessed via methods
        public string GetName()
        {
            return _name;
        }

        public void SetName(string s)
        {
            _name = s;
        }

        public void SetAuthor(string s)
        {
            _author = s;
        }

        public void SetPagecount(int c)
        {
            _pagecount = c;
        }
    }
}