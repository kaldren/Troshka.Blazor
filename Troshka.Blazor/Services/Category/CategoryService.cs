using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.Category;

namespace Troshka.Blazor.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public CategoryService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<List<CategoryModel>> GetAll()
        {
            using var context = _dbFactory.CreateDbContext();

            List<CategoryEntity> categories = await context.Category.AsNoTracking().ToListAsync();

            return _mapper.Map<List<CategoryModel>>(categories);
        }
    }
}
