using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.User;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models.User;

namespace Troshka.Blazor.Services.User
{
    public class UserService : IUserService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public UserService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<UserModel> CreateUserAsync(CreateUserModel model)
        {
            using var context = _dbFactory.CreateDbContext();

            var existing = await GetUserAsync(model.Id);

            if (existing != null)
            {
                return _mapper.Map<UserModel>(existing);
            }

            UserEntity userEntity = _mapper.Map<UserEntity>(model);

            context.Users.Add(userEntity);
            await context.SaveChangesAsync();

            return _mapper.Map<UserModel>(userEntity);
        }

        public async Task<UserModel> GetUserAsync(string id)
        {
            using var context = _dbFactory.CreateDbContext();

            UserEntity? userEntity = await context.Users.Where(p => p.Id == id).SingleOrDefaultAsync();

            return _mapper.Map<UserModel>(userEntity);
        }
    }
}
