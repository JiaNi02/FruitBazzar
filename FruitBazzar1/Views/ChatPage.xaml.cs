using FruitBazzar1.Model;
using System.Collections.ObjectModel;

namespace FruitBazzar1.Views;

public partial class ChatPage : ContentPage
{

    public ChatPage(ChatPageViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = viewModel;
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        (this.BindingContext as ChatPageViewModel).Initialize();
    }

}