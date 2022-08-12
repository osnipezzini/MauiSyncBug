using CommunityToolkit.Maui;

using MauiSyncBug.Pages;
using MauiSyncBug.ViewModels;

using Microsoft.Maui.Handlers;

namespace MauiSyncBug;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		WindowHandler.Mapper.ModifyMapping(nameof(IWindow.Content), (handler, window, _) => WindowHandler.MapContent(handler, window));
		builder.ConfigureEssentials(essentials => essentials.UseVersionTracking());
		builder.UseMauiCommunityToolkit();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<SyncPage>();
		builder.Services.AddTransient<SyncViewModel>();
		builder.Services.AddTransient<SyncDetailViewModel>();

		return builder.Build();
	}
}
