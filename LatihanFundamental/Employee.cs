namespace LatihanFundamental;
public class Employee : Person
{
    public string NIK { get; set; }
    public int Salary { get; set; }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"My NIK is {NIK} and my salary is {Salary}");
    }
}
