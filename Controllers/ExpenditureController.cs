using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplatingRazor.Models;

namespace TemplatingRazor.Controllers
{
    public class ExpenditureController : Controller
    {
        private readonly ILogger<ExpenditureController> _logger;
        public ExpenditureController(ILogger<ExpenditureController> logger)
        {
            _logger = logger;
        }
        public IActionResult Expenditure()
        {           
            List<Expenditure> Expends = new List<Expenditure>();
            Expends.Add(new Expenditure
            {
                name = "Depense 1",
                date = new DateTime(),
                price = 10
            });
            Expends.Add(new Expenditure
            {
                name = "Depense 2",
                date = new DateTime(),
                price = 18
            });
            Expends.Add(new Expenditure
            {
                name = "Depense 3",
                date = new DateTime(),
                price = 50
            }); 
            Expends.Add(new Expenditure
            {
                name = "Depense 4",
                date = new DateTime(),
                price = 25
            });
            return View(Expends);
        }
    }
}
