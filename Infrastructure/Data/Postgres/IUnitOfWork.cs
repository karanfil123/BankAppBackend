using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    ITransactionRepository Transactions { get; }
    IAccountRepository Accounts { get; }
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }

    Task<int> CommitAsync();
}