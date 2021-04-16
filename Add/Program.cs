using System;

namespace Add
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = 3569825;
            address.Country = "UA";
            address.City = "Gjksf";
            address.Street = "hfbvkdfbbvdf";
            address.House = 5;
            address.Apartment = 7;

            address.Show();
        }
    }
}
