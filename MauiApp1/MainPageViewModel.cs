using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.Shapes;

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
            var navigationParameters = new Dictionary<string, object>
            {
                { "Message", "Hello from MainPageViewModel!"   }
            };

            var response = (IPopupResult<SurveyResults>) await _popupService.ShowPopupAsync<MyPopupViewModel>(
                Shell.Current,
                options: new PopupOptions
                {
                    CanBeDismissedByTappingOutsideOfPopup = false,
                    Shape = new RoundRectangle
                    {
                        CornerRadius = new CornerRadius(3),
                        StrokeThickness = 0
                    },
                    Shadow = null
                },
                shellParameters: navigationParameters);

            if(response != null && response.Result is not null)
            {
                SurveyResults result = response.Result;
            }
        }
    }
}