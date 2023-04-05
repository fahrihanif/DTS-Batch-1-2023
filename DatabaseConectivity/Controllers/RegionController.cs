using DatabaseConnectivity.Models;
using DatabaseConnectivity.Repositories.Interface;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers;
public class RegionController
{
    private readonly IGeneralRepository<Region> _regionRepository;

    public RegionController(IGeneralRepository<Region> regionRepository)
    {
        _regionRepository = regionRepository;
    }

    public void GetAll()
    {
        var regions = _regionRepository.GetAll();
        var view = new VRegion();
        if (regions == null) {
            view.DataNotFound();
        } else {
            view.GetAll(regions);
        }
    }

    public void Insert(Region region)
    {
        var regions = _regionRepository.Insert(region);
        var view = new VRegion();
        if (regions > 0) {
            view.Success("Save");
        } else {
            view.Failure("Save");
        }
    }
}
