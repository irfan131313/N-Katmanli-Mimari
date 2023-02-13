using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Eticaret.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EntityLayer.Concrete;

namespace Eticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        PersonelManager personelManager = new PersonelManager(new EfPersonelDal());

        public IActionResult Index()
        {

            var values = personelManager.GetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Personel p1)
        {

            personelManager.TAdd(p1);

            return RedirectToAction("Index");
        }

      


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}