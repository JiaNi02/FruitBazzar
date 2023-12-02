using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitBazzar1.Services
{
    public class MockNotificationService : INotificationService
    {
        public Task<List<Notifications>> GetNotifications()
        {
            var records = new List<Notifications>()
        {
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            }
        };
            return Task.FromResult(records);
        }

        public Task<Notifications> GetNotificationByIdAsync(int id)
        {
            return Task.FromResult(new Notifications()
            {
                Title = "Title",
                Content =
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImagePath = "notif_image.png",
                NotificationDateTime = DateTime.Now
            });
        }
    }

    public interface INotificationService
    {
    }
}
