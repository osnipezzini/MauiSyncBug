using MauiSyncBug.ViewModels;

namespace MauiSyncBug.Pages;

public partial class SyncDetailPage : ContentPage
{
    private readonly SyncDetailViewModel viewModel;

    public SyncDetailPage(SyncDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = this.viewModel = viewModel;
    }
    protected override bool OnBackButtonPressed()
    {
        Shell.Current.GoToAsync("..");
        return true;
    }
}