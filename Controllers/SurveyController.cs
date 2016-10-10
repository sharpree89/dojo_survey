using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Survey.Controllers
{
 public class SurveyController : Controller                        
 {
    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        return View("index"); 
    }
    [HttpPost]
    [Route("/results")]
    public IActionResult Results(string name, string location, string language, string comments)
    {
        @ViewBag.name = Request.Form["name"];
        @ViewBag.location = Request.Form["location"];
        @ViewBag.language = Request.Form["language"];
        @ViewBag.comments = Request.Form["comments"];     

        return View("users");    
    }
  }
}
