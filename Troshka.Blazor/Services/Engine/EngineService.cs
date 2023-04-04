using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Engine;

namespace Troshka.Blazor.Services.Engine
{
    public class EngineService : IEngineService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public EngineService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<EngineModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<EngineEntity> coupes = await context.Engines.AsNoTracking().ToListAsync();

            return _mapper.Map<List<EngineModel>>(coupes);
        }
    }
}
