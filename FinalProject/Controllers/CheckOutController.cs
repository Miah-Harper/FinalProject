using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FinalProject.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly ILogger<CheckOutController> _logger;

        public CheckOutController(ILogger<CheckOutController>logger)
        {
            _logger = logger;
        }


    }
}

