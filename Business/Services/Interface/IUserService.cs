using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services.Interface
{
    public interface IUserService : IBaseService<User, int, UserProfileDto>
    {
    }
}
