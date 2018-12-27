using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AtlasCompanyTracker.Models;
using AtlasCompanyTracker.Models.Models;

namespace AtlasCompanyTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var resource = new ResourceModel
            {
                Name = "Metal",
                Thumbnail = "/images/metal.png"
            };
            resource = APIClient.PostAsync<ResourceModel>("api/Resource", resource).Result;

            var goal = new GoalModel
            {
                Resource = resource,
                StartingQuantity = 0,
                EndingQuantity = 100,
                Timeframe = (int)GoalModel.TimeframeEnum.Month
            };
            goal = APIClient.PostAsync<GoalModel>("/api/Goal", goal).Result;

            ViewData["Message"] = goal.ID.ToString();

            return View();
        }

        public IActionResult About()
        {
            var resource = new ResourceModel
            {
                Name = "Metal",
                Thumbnail = "/images/metal.png"
            };
            resource = APIClient.PostAsync<ResourceModel>("api/Resource", resource).Result;

            var goal = new GoalModel
            {
                Resource = resource,
                StartingQuantity = 0,
                EndingQuantity = 100,
                Timeframe = (int)GoalModel.TimeframeEnum.Month
            };
            goal = APIClient.PostAsync<GoalModel>("api/Goal", goal).Result;

            ViewData["Message"] = goal.ID.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
