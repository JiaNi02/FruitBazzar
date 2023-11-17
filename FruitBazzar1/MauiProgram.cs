using FruitBazzar1.Services;
using FruitBazzar1.ViewModel;
using FruitBazzar1.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

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


				fonts.AddFont("Brands-Regular-400.otf", "FAB");
				fonts.AddFont("Free-Regular-400.otf", "FAR");
				fonts.AddFont("Free-Solid-900.otf", "FAS");
			})
			.UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		AddProductServices(builder.Services);
		return builder.Build();
	}
	private static IServiceCollection
		AddProductServices(IServiceCollection services)
	{
		services.AddSingleton<ProductService>();
		services.AddScopedWithShellRoute<HomePage,
			HomeViewModel>(nameof(HomePage));
		services.AddTransientWithShellRoute<ProductPage,ProductViewModel>(nameof(ProductPage));
        services.AddTransientWithShellRoute<DetailsPage, DetailsViewModel>(nameof(DetailsPage));
        services.AddTransientWithShellRoute<ProfilePage, ProfileViewModel>(nameof(ProfilePage));


        return services;
	}
}
