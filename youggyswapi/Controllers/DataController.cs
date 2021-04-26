using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youggyswapi.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Refresh(string exchange, string symbol)
        {
            return View();
        }
    }
}
