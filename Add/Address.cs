using System;
using System.Collections.Generic;
using System.Text;

namespace Add
{
    class Address
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;

        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public void Show()
        {
            Console.WriteLine(Index);
            Console.WriteLine(Country);
            Console.WriteLine(City);
            Console.WriteLine(Street);
            Console.WriteLine(House);
            Console.WriteLine(Apartment);
        }
    }
}
