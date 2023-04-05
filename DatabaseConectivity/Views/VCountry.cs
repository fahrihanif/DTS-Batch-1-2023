using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;
public class VCountry : BaseView
{
    public void GetAll(List<Country> countries)
    {
        foreach (var country in countries) {
            Console.WriteLine("=============================");
            Console.WriteLine("Id: " + country.Id);
            Console.WriteLine("Name: " + country.Name);
            Console.WriteLine("Region Id: " + country.RegionId);
        }
    }
}
