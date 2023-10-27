using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Transaction : Entity<int>
    {
        public Transaction()
        {
            TransactionDateTime = DateTime.UtcNow.ToTimeZone();
        }

        public int AccountId { get; set; } //gönderen heasp
     
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }

      
        public virtual Accounts Account { get; set; }
       
    }

}
