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

namespace FruitBazzar1.ViewModel
{
    public partial class ProfileViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }
        public string UserName { get; set; } = "User Name";
        public string Email { get; set; } = "user@gmail.com";

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
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\uf3eb", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Shipping Address", Body = "\uf34e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Wishlist", Body = "\uf2d5", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Order History", Body = "\uf150", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Cards", Body = "\uf19b", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Notifications", Body = "\uf09c", TargetType = typeof(HomePage) });
        }

        private void CommandInit()
        {
            TapCommand = new Command<MenuItems>(item =>
            {
                Application.Current.MainPage.Navigation.PushModalAsync(((Page)Activator.CreateInstance(item.TargetType)));
            });

        }
    }
}
