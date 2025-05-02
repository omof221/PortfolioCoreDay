using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultAboutComponentPartial: ViewComponent
    { PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        { 
            var values=context.abouts.ToList();
            return View(values); }
    }
}
