using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class JobController : Controller
    { PortfolioContext context= new PortfolioContext();
        public IActionResult JobList()
        {
            var values = context.myjobss.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateJob()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateJob(Myjobs myjobs)
        {
            context.myjobss.Add(myjobs);
            context.SaveChanges();
            return RedirectToAction("JobList");
        }
        public IActionResult DeleteJob(int id)
        {
            var value = context.myjobss.Find(id);
            context.myjobss.Remove(value);
            context.SaveChanges();
            return RedirectToAction("JobList");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = context.myjobss.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateJob(Myjobs myjobs)
        {
            context.myjobss.Update(myjobs);
            context.SaveChanges();
            return RedirectToAction("JobList");
        }
    }
}
