using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Superhero class
        Superhero ironMan = new Superhero();

        // Set the power level of Iron Man's suit
        ironMan.SuitPowerLevel = 100;

        // Get Iron Man's suit power level
        int powerLevel = ironMan.SuitPowerLevel;
        Console.WriteLine($"Iron Man's suit power level: {powerLevel}");
    }
}

public class Superhero
{
    private int suitPowerLevel; // Hidden treasure

    public int SuitPowerLevel
    {
        get { return suitPowerLevel; } // Fetching power level
        set { suitPowerLevel = value; } // Boosting the suit's capabilities
    }
}
