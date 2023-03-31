namespace LatihanFundamental;

class Program
{
    public static void Main()
    {
        Person hanif = new Person();
        hanif.Name = "Hanif";
        hanif.Age = 20;
        hanif.Address = "Jl. Kebon Jeruk";
        hanif.Phone = "08123456789";

        Person rizal = new Person {
            Name = "Rizal",
            Age = 20,
            Address = "Jl. Kebon Jeruk",
            Phone = "08123456789"
        };

        List<Person> persons = new List<Person>();

        persons.Add(hanif);
        persons.Add(rizal);
        persons.Add(new Person {
            Name = "Alvina",
            Age = 20,
            Address = "Jl. Kebon Jeruk",
            Phone = "08123456789"
        });
        persons.Add(new Person {
            Name = "Rizky",
            Age = 20,
            Address = "Jl. Kebon Jeruk",
            Phone = "08123456789"
        });
        persons.Add(new Person {
            Name = "Violet",
            Age = 20,
            Address = "Jl. Kebon Jeruk",
            Phone = "08123456789"
        });

        var names = persons.Where(p => p.Name.Contains("Ha")).ToList();

        var names2 =
            (from p in persons
             where p.Name.Contains("Ha")
             select p).ToList();

        Console.WriteLine(DateTime.Now);
        foreach (var person in names) {
            Console.WriteLine(person.Name);
        }
    }
}