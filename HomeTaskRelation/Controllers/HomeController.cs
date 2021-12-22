using HomeTaskRelation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HomeTaskRelation.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        public ActionResult Index()
        {
            List<Group> group = _context.Groups.Include(g => g.Students).ToList();



            return View(group);
        }
    }
}
