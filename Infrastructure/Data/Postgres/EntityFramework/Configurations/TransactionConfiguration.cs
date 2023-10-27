using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.TransactionDateTime).IsRequired();
            builder.Property(x => x.TransactionType).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();


            builder.HasOne(x => x.User)
              .WithMany(x => x.Transactions)
              .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Cascade);


            builder.HasOne(x => x.Account)
             .WithMany(x => x.Transactions)
             .HasForeignKey(x => x.AccountId)
             .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
