using Microsoft.AspNetCore.Mvc;
using PatientList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientList.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientDbContext _dbContext;
        public PatientController(PatientDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult PatientList()
        {
            var patientData = _dbContext.PatientDatas;
            return View(patientData);
        }
    }
}
