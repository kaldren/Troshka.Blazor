using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.EuroStandard;

namespace Troshka.Blazor.Services.EuroStandard
{
    public class EuroStandardService : IEuroStandardService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public EuroStandardService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<EuroStandardModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<EuroStandardEntity> euro = await context.EuroStandards.OrderBy(p => p.Name).AsNoTracking().ToListAsync();

            return _mapper.Map<List<EuroStandardModel>>(euro);
        }
    }
}
