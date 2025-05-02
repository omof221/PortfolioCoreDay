using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class EducationController : Controller
    { PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var values = context.educations.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            context.educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult DeleteEducation(int id)
        {
            var values = context.educations.Find(id);
            context.educations.Remove(values);  
            context.SaveChanges();
            return RedirectToAction("EducationList");
        
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = context.educations.Find(id);
            return View(values);  
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education education)
        { context.educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");


        }

    }
}
