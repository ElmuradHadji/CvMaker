using CVMaker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CVMaker.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PrimaryData primaryData)
        {
            //_currencyService.Create(currencyPostDto);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int id)
        {
            //_currencyService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}