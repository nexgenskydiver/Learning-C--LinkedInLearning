using System;

namespace Inheritance
{
    // Declare "Magazine" as a subclass of Publication
    class Magazine : Publication
    {
        private string _publisher;

        public Magazine(string name,string publisher, int pagecount, decimal price) : base(name, pagecount, price)
        {
            _publisher = publisher;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }
    }
}