using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultMessageComponentPartial:ViewComponent
    { public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
