﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;

namespace MicroRabbit.Infrastructure.IoC
{
  public class DependencyContainer
  {
    public static void RegisterServices(IServiceCollection services)
    {
      //Domain Bus
      services.AddTransient<IEventBus, RabbitMQBus>();

      //Application Services
      services.AddTransient<IAccountService, AccountService>();

      //Data
      services.AddTransient<IAccountRepository, AccountRepository>();
      services.AddTransient<BankingDbContext>();

    }
  }
}
