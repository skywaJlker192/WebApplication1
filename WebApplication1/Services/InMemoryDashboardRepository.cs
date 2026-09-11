using DashboardAdmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace DashboardAdmin.Services
{
    public class InMemoryDashboardRepository : IDashboardRepository
    {
        private static readonly List<DashboardCard> _cards = new List<DashboardCard>
        {
            new DashboardCard { Id = 1, Title = "Выручка", Value = 150000M, Trend = Trend.Up, Unit = "руб.", Description = "Общая выручка за месяц" },
            new DashboardCard { Id = 2, Title = "Новые клиенты", Value = 45, Trend = Trend.Up, Unit = "шт.", Description = "Количество регистраций" },
            new DashboardCard { Id = 3, Title = "Возвраты", Value = -12500M, Trend = Trend.Down, Unit = "руб.", Description = "Сумма оформленных возвратов" }, // Отрицательное значение
            new DashboardCard { Id = 4, Title = "Конверсия", Value = 3.4M, Trend = Trend.Stable, Unit = "%", Description = "Средняя конверсия сайта" },
            new DashboardCard { Id = 5, Title = "Продажи товара А", Value = 850, Trend = Trend.Down, Unit = "шт.", Description = "Продажи основного SKU" },
            new DashboardCard { Id = 6, Title = "Средний чек", Value = 4500, Trend = Trend.Stable, Unit = "руб.", Description = "Показатель среднего чека" }
        };

        public IEnumerable<DashboardCard> GetAllCards() => _cards;

        public DashboardCard GetById(int id) => _cards.FirstOrDefault(c => c.Id == id);

        public IEnumerable<DashboardCard> GetLatest(int count) => _cards.OrderByDescending(c => c.Id).Take(count);
    }
}