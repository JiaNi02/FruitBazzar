using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.ViewModel
{
    public class NotificationViewModel : BindableObject
    {
        private ObservableCollection<Notifications> _notifications;
        private readonly INotificationService _notificationService;

        public ObservableCollection<Notifications> Notifications
        {
            get => _notifications;
            set
            {
                _notifications = value;
                OnPropertyChanged();
            }
        }

        public NotificationViewModel(INotificationService notificationService)
        {
            _notificationService = notificationService;
            _notifications = new ObservableCollection<Notifications>();
            LoadNotifications();
        }

        private async void LoadNotifications()
        {
            var notifications = await _notificationService.GetNotifications();
            Notifications = new ObservableCollection<Notifications>(notifications);
        }
    }
}
