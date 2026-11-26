using System.Runtime.InteropServices;

public class Creature
{
    public string Name { get; set; } = "";
    public string Species { get; set; } = "";
    public int Energy { get; set; }
    
    
    public override string ToString()
    {
        return $"Name: {Name}, Species: {Species}, Energy: {Energy}";
    }
}
