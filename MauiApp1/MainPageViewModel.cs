using CommunityToolkit.Maui;

using CommunityToolkit.Mvvm.Input;

namespace MauiApp1
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly IPopupService _popupService;
        public MainPageViewModel(IPopupService popupService)
        {
            Title = "Main Page";
            _popupService = popupService;
        }

        [RelayCommand]
        async Task OpenPopupAsync()
        {
            await _popupService.ShowPopupAsync<MyPopupViewModel>(Shell.Current);
        }
    }
}