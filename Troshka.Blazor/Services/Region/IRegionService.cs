using Troshka.Blazor.Models.Region;

namespace Troshka.Blazor.Services.Region
{
    public interface IRegionService
    {
        Task<List<RegionModel>> GetAllRegions();
        Task<List<LocationModel>> GetAllLocations(string regionId);
    }
}
