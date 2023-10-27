using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Accounts : Entity<int>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string AccountType { get; set; }
        public int Balance { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }

}
