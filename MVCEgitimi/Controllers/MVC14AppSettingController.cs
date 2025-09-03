using Microsoft.AspNetCore.Mvc;

namespace MVCEgitimi.Controllers
{
    public class MVC14AppSettingController : Controller
    {
        private readonly IConfiguration _configuration;

        public MVC14AppSettingController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.Mesaj = $"Email: {_configuration["Email"]}";
            ViewBag.Mesaj += $" - MailSunucu: {_configuration["MailSunucu"]}";
            ViewBag.Mesaj += $" - UserName: {_configuration["MailKullanici:UserName"]}";
            ViewBag.Mesaj += $" - Password: {_configuration.GetSection("MailKullanici:Password").Value}";
            return View();
        }
    }
}
