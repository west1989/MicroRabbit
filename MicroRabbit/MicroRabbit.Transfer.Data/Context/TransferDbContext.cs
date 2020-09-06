using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MicroRabbit.Transfer.Data.Context
{
  public class TransferDbContext : DbContext
  {
    public TransferDbContext(DbContextOptions options): base(options)
    {
    }

    public DbSet<TransferLog> TransferLogs { get; set; }
  }

  public class TransferFactory : IDesignTimeDbContextFactory<TransferDbContext>
  {
    public TransferDbContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<TransferDbContext>();
      optionsBuilder.UseSqlServer("Server=.;Database=TransferDB;Trusted_Connection=True;MultipleActiveResultSets=True");

      return new TransferDbContext(optionsBuilder.Options);
    }
  }
}
