using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy = false;

        [ObservableProperty]
        string title = string.Empty;
    }
}