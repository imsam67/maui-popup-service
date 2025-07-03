using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1
{
    [QueryProperty(nameof(Message), nameof(Message))]
    public partial class MyPopupViewModel : BaseViewModel
    {
        IPopupService _popupService;
        public MyPopupViewModel(IPopupService popupService)
        {
            Title = "My Popup";
            _popupService = popupService;
        }

        private string message;
        public string Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }

        [RelayCommand]
        async Task OnCloseAsync()
        {
            await _popupService.ClosePopupAsync(Shell.Current, new SurveyResults
            {
                Name = "Johnny Bravo",
                Email = "johnny@CoolestGuyOnEarth.com",
                Rating = 5,
                Comments = "Way to go!"
            });
        }
    }
}