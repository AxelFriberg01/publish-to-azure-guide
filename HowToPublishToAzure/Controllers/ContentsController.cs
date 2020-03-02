using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HowToPublishToAzure.Controllers
{
    public class ContentsController : Controller
    {
        
        [Route("")]
        [Route("index")]
        [Route("start")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}