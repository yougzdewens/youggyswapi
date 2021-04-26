using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youggyswapi.Controllers
{
    public class DailyValuesController : Controller
    {
        public IActionResult Get(string exchange, string symbol, int nbMonth, int nbYear)
        {
            return View();
        }
    }
}
