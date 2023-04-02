using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Brand;

namespace Troshka.Blazor.Services.Category
{
    public class CarBrandService : ICarBrandService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public CarBrandService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<BrandModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<CarBrandEntity> categories = await context.CarBrands.AsNoTracking().ToListAsync();

            return _mapper.Map<List<BrandModel>>(categories);
        }
    }
}
