using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Transmission;

namespace Troshka.Blazor.Services.Transmission
{
    public class TransmissionService : ITransmissionService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public TransmissionService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<TransmissionModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<TransmissionEntity> coupes = await context.Transmissions.AsNoTracking().ToListAsync();

            return _mapper.Map<List<TransmissionModel>>(coupes);
        }
    }
}
