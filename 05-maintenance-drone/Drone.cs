public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    public string Describe()
    { 
        
        return $"Status - {Name}: {FlightHours} Flight hours";
    }

    public bool NeedsService()
    {
        if (FlightHours >= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
