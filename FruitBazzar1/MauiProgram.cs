using FruitBazzar1.Services;
using FruitBazzar1.ViewModel;
using FruitBazzar1.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using FruitBazzar1.Services.ChatHub;

namespace FruitBazzar1;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Lobster-Regular.ttf", "LobsterRegular");


                fonts.AddFont("Brands-Regular-400.otf", "FAB");
				fonts.AddFont("Free-Regular-400.otf", "FAR");
				fonts.AddFont("Free-Solid-900.otf", "FAS");
			})
			.UseMauiCommunityToolkit();

		
        builder.Services.AddSingleton<ChatHub>();
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<ListChatPage>();
        builder.Services.AddSingleton<ChatPage>();
		//builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<ListChatPageViewModel>();
        builder.Services.AddSingleton<ServiceProvider>();

#if DEBUG
        builder.Logging.AddDebug();
#endif
        //builder.Services.AddHttpClient("api", httpClient => httpClient.BaseAddress = new Url("https://localhost:44350/swagger/index.html");
        AddProductServices(builder.Services);
		return builder.Build();
	}
	private static IServiceCollection
		AddProductServices(IServiceCollection services)
	{
		services.AddSingleton<ProductService>();

		services.AddSingleton<HomePage>()
				.AddSingleton<HomeViewModel>();
        services.AddSingleton<LoginPage>()
                .AddSingleton<LoginViewModel>();
        services.AddSingleton<RegisterPage>()
               .AddSingleton<RegisterViewModel>();



        services.AddTransientWithShellRoute<ProductPage,ProductViewModel>(nameof(ProductPage));
        services.AddTransientWithShellRoute<DetailsPage, DetailsViewModel>(nameof(DetailsPage));
        services.AddTransientWithShellRoute<PaymentPage, PaymentViewModel>(nameof(PaymentPage));
        services.AddTransientWithShellRoute<ProfilePage, ProfileViewModel>(nameof(ProfilePage));
        services.AddTransientWithShellRoute<LoginPage, LoginViewModel>(nameof(LoginPage));
        services.AddTransientWithShellRoute<RegisterPage, RegisterViewModel>(nameof(RegisterPage));
        services.AddTransientWithShellRoute<CategoryProductPage, CategoryProductViewModel>(nameof(CategoryProductPage));

        services.AddSingleton<CartViewModel>();
        services.AddTransient<CartPage>();

        services.AddSingleton<CartViewModel>()
                .AddSingleton<CartPage>();
        return services;
	}
}
