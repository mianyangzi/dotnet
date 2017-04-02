using dotnet.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Controllers
{
    public class AccountsController:Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Register()
        {
            _logger.LogInformation("注册开始");
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel Model)
        {
            _logger.LogInformation("提交注册");
            if (ModelState.IsValid)
            {
                return View("RegisterCompleted");
            }
            else
            {
                _logger.LogError("注册失败");
            }
            return View();
        }
    }
}
