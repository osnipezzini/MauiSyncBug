using MauiSyncBug.Pages;

namespace MauiSyncBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(SyncDetailPage), typeof(SyncDetailPage));
    }
}
