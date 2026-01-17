using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.DriverAssignmentSystem
{
    // Driver class
    public class Driver
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public double Distance { get; set; }
        public double Rating { get; set; }
        public bool IsAvailable { get; set; }
        public int CancelCount { get; set; }

        public Driver(int id, double distance, double rating)
        {
            Id = id;
            Distance = distance;
            Rating = rating;
            IsAvailable = true;
            CancelCount = 0;
        }
    }
}