using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Model;

namespace Troshka.Blazor.Services.Category
{
    public class CarModelService : ICarModelService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public CarModelService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<ModelModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<CarModelEntity> categories = await context.CarModels.AsNoTracking().ToListAsync();

            return _mapper.Map<List<ModelModel>>(categories);
        }

        public async Task<List<ModelModel>> GetAll(string brandId)
        {
            using var context = _dbFactory.CreateDbContext();

            List<CarModelEntity> categories = await context.CarModels.Where(p => p.CarBrandId == brandId).AsNoTracking().ToListAsync();

            return _mapper.Map<List<ModelModel>>(categories);
        }
    }
}
