using Business.Models.Request;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class TransactionController : BaseCRUDController<Transaction, int, TransactionCreateDto, TransactionUpdateDto, TransactionDto>
    {
        public TransactionController(ITransactionService service) : base(service)
        {
        }
    }
}
