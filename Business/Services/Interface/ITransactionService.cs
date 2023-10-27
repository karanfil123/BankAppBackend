using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services.Interface
{
    public interface ITransactionService : IBaseService<Transaction, int, TransactionDto>
    {
    }
}
