
/** 
    Compile-time Polymorphism (Method Overloading)
*/
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(2, 3));       // Outputs: 5
        Console.WriteLine(calc.Add(2.5, 3.5));   // Outputs: 6.0
    }
}