namespace LatihanFundamental;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public Person()
    {
        //Console.WriteLine("Ini adalah instantiation sebuah objek");
    }

    public Person(string name)
    {
        Name = name;
    }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}, I am {Age} years old, I live in {Address}, and my phone number is {Phone}");
    }

    public virtual void Introduce(string name)
    {
        Console.WriteLine($"Hello {name}, my name is {Name}, I am {Age} years old, I live in {Address}, and my phone number is {Phone}");
    }

    public void Eat()
    {
        Console.WriteLine("I am eating");
    }
}