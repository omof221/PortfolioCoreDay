using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMyProjectComponentPartial: ViewComponent
    {PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {var values=context.portfolios.ToList();
            return View(values);    


        }






    }
}
