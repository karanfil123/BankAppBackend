using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AccountDto
    {
        public int Id { get; set; } = default!;
        public int UserId { get; set; }
        public string AccountType { get; set; }
        public int Balance { get; set; }
    }
}
