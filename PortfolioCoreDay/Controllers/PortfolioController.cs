using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    { PortfolioContext context = new PortfolioContext();
        public IActionResult ProjectList()
        {  // include ile join işlemi yapılır
            var values = context.portfolios.Include(x => x.Category).ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult CreatePortfolio() 
        { var values = new SelectList(context.categories.ToList(), "CategoryId","CategoryName");
            ViewBag.v=values;
            return View();
        
        }
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio) 
        {
            context.portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("ProjectList");
        
        }
        public IActionResult DeletePortfolio(int id)
        {
            var value = context.portfolios.Find(id);
            context.portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjectList");


        }
        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.portfolios.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
           
            context.portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("ProjectList");



        }
    }
}
