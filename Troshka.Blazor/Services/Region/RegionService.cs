using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.Region;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Region;

namespace Troshka.Blazor.Services.Region
{
    public class RegionService : IRegionService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public RegionService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }
        public async Task<List<LocationModel>> GetAllLocations(string regionId)
        {
            using var context = _dbFactory.CreateDbContext();

            List<LocationEntity> regions = await context.Locations.Where(p => p.RegionId == regionId).OrderBy(p => p.Name).AsNoTracking().ToListAsync();

            return _mapper.Map<List<LocationModel>>(regions);
        }

        public async Task<List<RegionModel>> GetAllRegions()
        {
            using var context = _dbFactory.CreateDbContext();

            List<RegionEntity> regions = await context.Regions.OrderBy(p => p.Name).AsNoTracking().ToListAsync();

            return _mapper.Map<List<RegionModel>>(regions);
        }
    }
}
