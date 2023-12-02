﻿namespace FruitBazzar1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(ProductPage), typeof(ProductPage));
        Routing.RegisterRoute("ListChatPage", typeof(ListChatPage));
        Routing.RegisterRoute(nameof(ChatPage), typeof(ChatPage));
        Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
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
