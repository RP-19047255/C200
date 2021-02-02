using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApp_3.Models;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApp_3.Controllers
{
    public class HomeController : Controller
    {
            [HttpGet]
        public IActionResult Index()
        {

            RestClient restClient = new RestClient("https://c200-teamb-api.azurewebsites.net/");

            RestRequest restRequest = new RestRequest("api/detections", Method.GET);

            IRestResponse restResponse = restClient.Execute(restRequest);

            string response = restResponse.Content;

            var listDetect = JsonConvert.DeserializeObject<List<Detections>>(response);

            int counter = listDetect.Count;


            return View(listDetect);

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
