using DashboardAdmin.Services;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
//using WebApplication1.Services;

namespace WebApplication1.Controllers   // ← ИСПРАВИТЬ ЗДЕСЬ
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _repository;

        public DashboardController(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewData["ReportPeriod"] = "Сентябрь 2026";
            ViewBag.Currency = "RUB";

            var cards = _repository.GetAllCards();
            return View(cards);
        }
    }
}