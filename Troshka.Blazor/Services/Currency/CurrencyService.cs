using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Currency;

namespace Troshka.Blazor.Services.Currency
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public CurrencyService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<CurrencyModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<CurrencyEntity> categories = await context.Currencies.AsNoTracking().ToListAsync();

            return _mapper.Map<List<CurrencyModel>>(categories);
        }
    }
}
