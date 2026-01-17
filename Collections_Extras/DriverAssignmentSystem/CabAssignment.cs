    /*
    Cab Driver Assignment System
Problem Statement
Assign cab drivers optimally.
Use:
● List<Driver>
● SortedList<double, Driver>
Tasks
1. Assign nearest available driver.
2. If distance same, choose highest rating.
3. Handle ride cancellation and reassignment.
4. Penalize drivers with frequent cancellations.
Edge Cases Students Miss
● No drivers available
● Equal distance & rating
● Driver becomes unavailable mid-assignment
● Floating-point comparison issues
● Reassigning same driver again
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_Advance_Collections.Collections_Extras.DriverAssignmentSystem
{
    public class CabAssignment
    {
        private List<Driver> drivers; // private list for drivers data
        private const int MAX_CANCELS = 3;
        public CabAssignment(List<Driver> driverList)
        {
            drivers = driverList;
        }

        // method to handle cancellation
        public void CancelRide(Driver driver)
        {
            if (driver == null) return;

            driver.CancelCount++;
            driver.IsAvailable = true;

            if (driver.CancelCount >= MAX_CANCELS) Console.WriteLine($"Driver {driver.Id} penalized");
        }

        // method to assign nearest available driver
        public Driver AssignDriver()
        {
            var availableDrivers = drivers
                .Where(d => d.IsAvailable && d.CancelCount < MAX_CANCELS)
                .OrderBy(d => Math.Round(d.Distance, 2))
                .ThenByDescending(d => d.Rating)
                .ThenBy(d => d.Id)
                .ToList();
            if (availableDrivers.Count == 0)
            {
                Console.WriteLine("No drivers available");
                return null;
            }
            Driver assigned = availableDrivers.First();
            assigned.IsAvailable = false;
            return assigned;
        }
    }
}