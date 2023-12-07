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
                Title = "New Fruit",
                Content = "Explore the latest fruits in our store!",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Special Offer",
                Content = "Get 20% off on all tropical fruits!",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Seasonal Picks",
                Content = "Check out our seasonal fruit recommendations.",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Fresh Arrival",
                Content = "New batch of strawberries just in!",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Weekly Special",
                Content = "Apple sale: Buy 2, Get 1 Free!",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            },
            new Notifications()
            {
                Title = "Title",
                Content = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor.",
                ImageSource = "notif_image.png",
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
                ImageSource = "notif_image.png",
                NotificationDateTime = DateTime.Now
            });
        }

    }

}
