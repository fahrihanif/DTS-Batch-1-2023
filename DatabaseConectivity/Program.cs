using DatabaseConnectivity.Controllers;
using DatabaseConnectivity.Models;
using DatabaseConnectivity.Repositories;
using DatabaseConnectivity.Repositories.Interface;

namespace DatabaseConnectivity;

class Program
{
    static void Main(string[] args)
    {
        IGeneralRepository<Region> repository = new RegionRepository();
        RegionController regionController = new RegionController(repository);

        var region = new Region(null, "Cobaa");

        //regionController.Insert(region);
        regionController.GetAll();
    }
}