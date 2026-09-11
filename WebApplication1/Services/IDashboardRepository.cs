using DashboardAdmin.Models;
using System.Collections.Generic;

namespace DashboardAdmin.Services
{
    public interface IDashboardRepository
    {
        IEnumerable<DashboardCard> GetAllCards();
        DashboardCard GetById(int id);
        IEnumerable<DashboardCard> GetLatest(int count);
    }
}