class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("Dock", "Gate locked", "Yes");

        // TODO: Kall også din tredje overload.
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    static void PrintTransmission(string sender, string message, string priority)
    {
        Console.WriteLine($"[{sender}] {message} - {priority}");
    }

    // TODO: Lag tredje overload.
}