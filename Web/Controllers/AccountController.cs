using Business.Models.Request;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class AccountController : BaseCRUDController<Accounts, int, AccountCreateDto, AccountUpdateDto, AccountDto>
    {
        public AccountController(IAccountService service) : base(service)
        {
        }
    }
}
