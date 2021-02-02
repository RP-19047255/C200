using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace WebApp.Controllers
{
   public class DetectionsController : Controller
   {

      public IActionResult Index()
      {
         DataTable dt = DBUtl.GetTable("SELECT * FROM Detection");
         return View("Index", dt);

      }

   }
}