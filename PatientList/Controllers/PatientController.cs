using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientList.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult PatientList()
        {
            return View();
        }
    }
}
