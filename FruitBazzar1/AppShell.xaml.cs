﻿namespace FruitBazzar1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(StartPage), typeof(StartPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(ProductPage), typeof(ProductPage));
        Routing.RegisterRoute("ListChatPage", typeof(ListChatPage));
        Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
        Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        Routing.RegisterRoute(nameof(MorePage), typeof(MorePage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(NotificationPage), typeof(NotificationPage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(CategoryPage), typeof(CategoryPage));
    }
    //public AppShell(LoginPage loginPage)
    //{
    //    InitializeComponent();

    //    Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    //    Routing.RegisterRoute(nameof(ProductPage), typeof(ProductPage));
    //    Routing.RegisterRoute(nameof(ListChatPage), typeof(ListChatPage));
    //    Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
    //    Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
    //    Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));

    //    this.CurrentItem = loginPage;
    //}

}
