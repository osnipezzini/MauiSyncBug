using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiSyncBug.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private bool isBusy = false;
        [ObservableProperty]
        private bool isPassword = true;
    }
}
