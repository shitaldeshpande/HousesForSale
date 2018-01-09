using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HousesForSale2.Controllers
{
    public class HouseController : Controller
    {
        /// <summary>
        /// Agents the profile.
        /// </summary>
        /// <returns>return view</returns>
        public IActionResult Agent_Profile()
        {
            return View();
        }
    }
}