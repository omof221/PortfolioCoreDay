using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.ComponentModel;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSideBarComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.socialmedias.ToList();
            return View(value); 
        }
    }
}
