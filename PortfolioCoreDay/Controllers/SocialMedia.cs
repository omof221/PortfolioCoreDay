using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class SocialMedia : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SocialMediaList()
        {
            var value = context.socialmedias.ToList();
            return View(value);
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = context.socialmedias.Find(id);
            context.socialmedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
         
        }
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(Socialmedia socialMedia)
        {
            context.socialmedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = context.socialmedias.Find(id);
            return View(value); 

        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(Socialmedia socialmedia)
        {
            context.socialmedias.Update(socialmedia);
            context.SaveChanges();  

            return RedirectToAction("SocialMediaList");

        }



    }
}
