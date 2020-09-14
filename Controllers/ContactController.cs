using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyWorld.Controllers
{
    public class ContactController : Controller
    {
        //get to the view to use basic index action
        public IActionResult Index()
        {
            return View();
        }
    }
}
