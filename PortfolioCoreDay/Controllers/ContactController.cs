using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ContactList()
        {
            var car = context.contacts.ToList();
            return View(car);
        }
        public IActionResult DeleteContact(int id) 
        {
            var value = context.contacts.Find(id);
            context.contacts.Remove(value); 
            context.SaveChanges();
            return RedirectToAction("ContactList");   
        
        }
        [HttpGet]
        public IActionResult CreateContact() 
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        { context.contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        { var value = context.contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        { context.contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        
        }
    }
}
