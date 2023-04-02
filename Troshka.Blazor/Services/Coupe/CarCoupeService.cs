using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Coupe;

namespace Troshka.Blazor.Services.Coupe
{
    public class CarCoupeService : ICarCoupeService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public CarCoupeService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<CoupeModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<CarCoupeEntity> coupes = await context.CarCoupes.AsNoTracking().ToListAsync();

            return _mapper.Map<List<CoupeModel>>(coupes);
        }
    }
}
