using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Services
{
    public interface INotificationService
    {
        Task<List<Notifications>> GetNotifications();
        Task<Notifications> GetNotificationByIdAsync(int id);
    }
}
