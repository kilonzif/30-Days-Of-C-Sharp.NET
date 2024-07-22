/* Polymorphism with Interfaces in C# */

public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IShape shape1 = new Circle();
        IShape shape2 = new Square();
        
        shape1.Draw(); // Outputs: Drawing a circle
        shape2.Draw(); // Outputs: Drawing a square
    }
}