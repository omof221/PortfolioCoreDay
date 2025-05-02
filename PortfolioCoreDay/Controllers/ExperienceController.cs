using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class ExperienceController : Controller
    { PortfolioContext context = new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var value = context.experiences.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperence(Experience experience)
        {
            context.experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var values = context.experiences.Find(id);
            context.experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Experienceist");

        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = context.experiences.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");


        }

    }
}
