using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class AboutController : Controller
    { PortfolioContext context = new PortfolioContext();
        public IActionResult AboutList()
        {
            var values = context.abouts.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAbout()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(About about)
        {
            context.abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.abouts.Find(id);
            context.abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.abouts.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
