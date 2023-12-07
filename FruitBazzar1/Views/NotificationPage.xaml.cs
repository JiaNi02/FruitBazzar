using FruitBazzar1.ViewModel;

namespace FruitBazzar1.Views;

public partial class NotificationPage : ContentPage
{
    private NotificationViewModel _viewModel;

    public NotificationPage()
    {
        InitializeComponent();
        _viewModel = new NotificationViewModel(new MockNotificationService());
        BindingContext = _viewModel;
    }
}