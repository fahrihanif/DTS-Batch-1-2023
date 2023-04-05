using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views;
public class VRegion : BaseView
{
    public void GetAll(List<Region> regions)
    {
        foreach (var region in regions) {
            Console.WriteLine("=============================");
            Console.WriteLine("Id: " + region.Id);
            Console.WriteLine("Name: " + region.Name);
        }
    }
}
