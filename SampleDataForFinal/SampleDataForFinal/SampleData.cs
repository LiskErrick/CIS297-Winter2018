using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataForFinal
{
    public class SampleData
    {
        public Hotel Hotel {get;set;}
        public SampleData()
        {
            Hotel = new Hotel();
            for( int number = 1; number <= 100; number++)
            {
                Hotel.Rooms.Add(new Room { Number = number });
            }
            Customer Eric = new Customer { Name = "Eric", Balance = 123.0 };
            Hotel.Rooms[0].Occupant = Eric;
        }
    }

    public class Hotel
    {
        public List<Room> Rooms { get; set; }

        public Hotel()
        {
            Rooms = new List<Room>();
        }
    }

    public class Room
    {
        public int Number { get; set; }
        public Customer Occupant { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
    }
}
