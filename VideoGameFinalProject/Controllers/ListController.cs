using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameFinalProject.Controllers
{
    public class ListController : Controller
    {
        private readonly ILogger<ListController> _logger;

        public ListController(ILogger<ListController> logger)
        {
            _logger = logger;
        }
        public IActionResult TopGames()
        {
            return View();
        }
    }
}
