using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SharingIsCaring.Controllers
{
    public class AssetTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
