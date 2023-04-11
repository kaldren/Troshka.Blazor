using Troshka.Blazor.Models.User;

namespace Troshka.Blazor.Services.User
{
    public interface IUserService
    {
        Task<UserModel> GetUserAsync(string Id);
        Task<UserModel> CreateUserAsync(CreateUserModel model);
    }
}
