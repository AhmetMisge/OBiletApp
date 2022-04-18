using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OBiletAPP.Clients;
using OBiletAPP.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OBiletAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OBiletClient _oBiletClient;

        public HomeController(ILogger<HomeController> logger, OBiletClient oBiletClient)
        {
            _logger = logger;
            _oBiletClient = oBiletClient;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _oBiletClient.GetBusLocation();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> JourneyIndex(int originID, int destinationID, string date)
        {
            var result = await _oBiletClient.GetJourney(originID, destinationID, date);
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
