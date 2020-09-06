using System.Collections.Generic;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BankingController : ControllerBase
  {
    private readonly IAccountService _accountService;

    public BankingController(IAccountService accountService)
    {
      _accountService = accountService;
    }

    // Get api/banking
    [HttpGet]
    public ActionResult<IEnumerable<Account>> Get()
    {
      var result = _accountService.GetAccounts();
      return Ok(result);
    }
  }
}
