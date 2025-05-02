using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatisticsComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.a1 = context.skills.Count();
            ViewBag.a2=context.myjobss.Count();    
            ViewBag.a3=context.messages.Count();
            Random rnd = new Random();
            ViewBag.a4 = rnd.Next(10, 31);

            return View();
        }
    }
}
