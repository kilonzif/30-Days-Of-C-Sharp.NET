
/* Run-time Polymorphism (Method Overriding) */
public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        
        myDog.Speak(); // Outputs: Dog barks
        myCat.Speak(); // Outputs: Cat meows
    }
}