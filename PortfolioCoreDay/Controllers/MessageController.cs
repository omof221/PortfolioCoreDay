using Microsoft.AspNetCore.Mvc;
//using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    { PortfolioContext context=new PortfolioContext();
        public IActionResult MessageList()
        { var value=context.messages.ToList();
            return View(value);
        }
        public IActionResult DeleteMessage(int  id)
        {
            var value=context.messages.Find(id);
            context.messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageList"); 

        }
        public IActionResult ChangeIsReadFalse(int id)
        {
            var value = context.messages.Find(id);
            value.IsRead= false;
            context.SaveChanges();
            return RedirectToAction("MessageList");

        }
        public IActionResult ChangeIsReadTrue(int id)
        {
            var value = context.messages.Find(id);
            value.IsRead = true;    
            context.SaveChanges();
            return RedirectToAction("MessageList");

        }
        public IActionResult MessageDetail(int id)
        {var value=context.messages.Find(id);   
            return View(value); 

        }
        //[HttpGet]
        //public IActionResult SendeMessage()
        //    { return View(); }
        //[HttpPost]
        //public IActionResult SendMessage(Message message)
        //    {  message.sendDate=DateTime.Now;
        //    message.IsRead = false;
        //    var values = context.Messages.Add(message);
        //    context.SaveChanges();
        //    TempData["SuccessMessage"] = "Mesajınız başarıyla gönderilmiştir!";
        //    return RedirectToAction("Index", "Default");

         
        
        //}  
    }
}
