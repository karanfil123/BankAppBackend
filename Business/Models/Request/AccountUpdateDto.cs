using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request
{
    public class AccountUpdateDto
    {
        public int UserId { get; set; }
        public string AccountType { get; set; }
        public int Balance { get; set; }
    }
}
