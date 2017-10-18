using Lab26Idenity.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab26Idenity.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lab26IdenityContext _context;
        public HomeController(Lab26IdenityContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.CMS.Where(c => c.ID > 0 );
            return View(result.ToList());
        }
    }
}
