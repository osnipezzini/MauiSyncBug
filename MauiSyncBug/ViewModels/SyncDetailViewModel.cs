using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using MauiSyncBug.Models;

namespace MauiSyncBug.ViewModels
{
    public partial class SyncDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Sync sync;

        [RelayCommand]
        public Task GoBack() => Shell.Current.GoToAsync("..");
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey(nameof(Sync)) && query[nameof(Sync)] is Sync sync)
                Sync = sync;
        }
    }
}
