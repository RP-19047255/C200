using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp_2.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace WebApp_2.Controllers
{
   public class DetectionsController : Controller
   {
        [AllowAnonymous]
      public IActionResult Index()
        {
            List<Detections> list = DBUtl.GetList<Detections>("SELECT * FROM Detections");
            return View("Index", list);
        }

   }
}