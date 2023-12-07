using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitBazzar1.Model;
using FruitBazzar1.Services;
using FruitBazzar1.Views;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using FruitBazzar1.Views;
using FruitBazzar1.Model;

namespace FruitBazzar1.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }

        public List<MenuItems> _MenuItems = new List<MenuItems>();
        public List<MenuItems> MenuItems
        {
            get { return _MenuItems; }
            set { _MenuItems = value; }
        }

        public ProfileViewModel()
        {
            PopulateData();
            CommandInit();
        }

        void PopulateData()
        {
            MenuItems.Clear();
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "profile.png", TargetType = typeof(EditProfilePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Shipping Address", Body = "profile.png", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Order History", Body = "profile.png", TargetType = typeof(HomePage) });
            //MenuItems.Add(new Model.MenuItems() { Title = "Track Order", Body = "\uf787", TargetType = typeof(OrderDetails) });
            MenuItems.Add(new Model.MenuItems() { Title = "Cards", Body = "profile.png", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Notifications", Body = "profile.png", TargetType = typeof(HomePage) });
        }

        private void CommandInit()
        {
            TapCommand = new Command<MenuItems>(item =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(((Page)Activator.CreateInstance(item.TargetType)));
            });

        }
        //private void EditProfile()
        //{
        //    // Navigate to EditProfilePage
        //    Application.Current.MainPage.Navigation.PushModalAsync(new EditProfilePage());
        //}
    }
}
