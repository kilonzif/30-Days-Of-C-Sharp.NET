using system;

namespace Inheritance {

public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of Car class
        Car myCar = new Car("Toyota", "Camry", 2022);

        // Set properties of Car class
        myCar.Speed = 60;
        myCar.Start();

        // Call method specific to Car class
        myCar.Accelerate();

        // Output the details of the Car
        Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model} cruising at {myCar.Speed} mph.");
    }
}

public class Vehicle
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle engine started.");
    }
}


public class Car : Vehicle
{
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Accelerate()
    {
        Speed += 10; // Increase speed by 10 mph
        Console.WriteLine("Car is accelerating.");
    }
}

}