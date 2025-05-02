using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController1 : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.skills.Count();// toplam yetenek sayısı
            ViewBag.v2= context.skills.Sum(x =>x.SkillValue);// yetenek değerlerinin toplamı
            ViewBag.v3= context.skills.Average(x =>x.SkillValue); // yetenek değerlerinin ortalaması
            ViewBag.v4=context.skills.Where(x => x.SkillValue> 80).Count();  // yetenek değeri 80 den büyük olanlar
            ViewBag.v5=context.experiences.Count(); //toplam deneyim
            ViewBag.v6=context.messages.Count();    // toplam mesaj
            ViewBag.v7=context.socialmedias.Count();    // kayıtlı sosyal medya sayısı
            ViewBag.v8=context.categories.Count();//  çalışılan teknolojiler vee diller
            ViewBag.v9=context.services.Count(x=> x.Status==true); // aktif servisler
            ViewBag.v10 = context.services.Count(x=> x.Status==false); // pasif durumdaki servisler
            Random rnd = new Random();
            ViewBag.v11=rnd.Next(10,31);
            return View();
        }
    }
}
