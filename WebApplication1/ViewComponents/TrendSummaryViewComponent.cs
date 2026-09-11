using DashboardAdmin.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DashboardAdmin.ViewComponents
{
    public class TrendSummaryViewComponent : ViewComponent
    {
        private readonly IDashboardRepository _repository;

        public TrendSummaryViewComponent(IDashboardRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            var cards = _repository.GetAllCards();

            var summary = cards
                .GroupBy(c => c.Trend)
                .Select(g => new
                {
                    TrendName = g.Key.ToString(),
                    Count = g.Count(),
                    Sum = g.Sum(c => c.Value)
                })
                .ToList();

            return View(summary);
        }
    }
}