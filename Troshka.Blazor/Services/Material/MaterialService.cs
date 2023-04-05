using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Material;

namespace Troshka.Blazor.Services.Material
{
    public class MaterialService : IMaterialService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public MaterialService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<MaterialModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<MaterialEntity> materials = await context.Materials.AsNoTracking().ToListAsync();

            return _mapper.Map<List<MaterialModel>>(materials);
        }
    }
}
