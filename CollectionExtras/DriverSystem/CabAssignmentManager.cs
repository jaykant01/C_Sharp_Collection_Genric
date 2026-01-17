using System;
using System.Collections.Generic;
namespace DriverSystem;

public class CabAssignmentManager
{
    private List<Driver> drivers = new List<Driver>();
    private const int MAX_CANCEL = 3;

    // Add driver
    public void AddDriver(Driver driver)
    {
        drivers.Add(driver);
    }

    //  Assign nearest available driver
    public Driver AssignDriver()
    {
        SortedList<double, Driver> sortedDrivers =
            new SortedList<double, Driver>();

        for (int i = 0; i < drivers.Count; i++)
        {
            Driver d = drivers[i];

            if (!d.IsAvailable || d.CancelCount >= MAX_CANCEL)
                continue;

            double key = d.Distance;

            while (sortedDrivers.ContainsKey(key))
            {
                key += 0.0001; 
            }

            sortedDrivers.Add(key, d);
        }

        if (sortedDrivers.Count == 0)
        {
            Console.WriteLine("No drivers available.");
            return null;
        }

        // Check same distance choose highest rating
        Driver bestDriver = sortedDrivers.Values[0];

        for (int i = 1; i < sortedDrivers.Values.Count; i++)
        {
            Driver current = sortedDrivers.Values[i];

            if (Math.Abs(current.Distance - bestDriver.Distance) < 0.001)
            {
                if (current.Rating > bestDriver.Rating)
                    bestDriver = current;
            }
        }

        bestDriver.IsAvailable = false;
        Console.WriteLine("Assigned Driver: " + bestDriver.Name);
        return bestDriver;
    }

    // Handle cancellation & reassignment
    public void CancelRide(Driver driver)
    {
        if (driver == null)
            return;

        driver.CancelCount++;
        driver.IsAvailable = true;

        Console.WriteLine("Ride cancelled by " + driver.Name);

        if (driver.CancelCount >= MAX_CANCEL)
        {
            driver.IsAvailable = false;
            Console.WriteLine(driver.Name + " penalized for frequent cancellations.");
        }
    }

    // Make driver unavailable 
    public void MarkUnavailable(Driver driver)
    {
        if (driver != null)
        {
            driver.IsAvailable = false;
            Console.WriteLine(driver.Name + " became unavailable.");
        }
    }

    // Display drivers
    public void DisplayDrivers()
    {
        Console.WriteLine("\nDriver Status:");
        for (int i = 0; i < drivers.Count; i++)
        {
            Driver d = drivers[i];
            Console.WriteLine(
                d.Name +
                "  Dist: " + d.Distance +
                "  Rating: " + d.Rating +
                " Available: " + d.IsAvailable +
                "  Cancels: " + d.CancelCount
            );
        }
    }
}
