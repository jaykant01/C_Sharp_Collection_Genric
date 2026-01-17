namespace DriverSystem;

public class Driver
{
    public int Id;
    public string Name;
    public double Distance;  
    public double Rating;
    public bool IsAvailable;
    public int CancelCount;

    public Driver(int id, string name, double distance, double rating)
    {
        Id = id;
        Name = name;
        Distance = distance;
        Rating = rating;
        IsAvailable = true;
        CancelCount = 0;
    }
}
