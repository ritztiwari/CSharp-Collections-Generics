using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.DriverAssignmentSystem
{
    public class CabAssignmentMain
    {
        public static void Execute()
        {
            List<Driver> drivers = new List<Driver>
            {
                new Driver(1, 2.5, 4.6),
                new Driver(2, 2.5, 4.8), // same distance, but higher rating
                new Driver(3, 3.0, 4.9)
            };

            CabAssignment service = new CabAssignment(drivers);
            Driver d1 = service.AssignDriver();
            Console.WriteLine($"Assigned Driver: {d1?.Id}");

            // Driver cancels ride
            service.CancelRide(d1);

            // Reassign driver
            Driver d2 = service.AssignDriver();
            Console.WriteLine($"Reassigned Driver: {d2?.Id}");
        }
    }
}