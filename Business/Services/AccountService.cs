using Business.Models.Response;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services
{
    public class AccountService : BaseService<Accounts, int, AccountDto>, IAccountService
    {
        public AccountService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.Accounts, mapperHelper)
        {
        }
    }
}
