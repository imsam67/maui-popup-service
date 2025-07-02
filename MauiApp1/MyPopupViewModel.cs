using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1
{
    public partial class MyPopupViewModel : BaseViewModel
    {
        public MyPopupViewModel()
        {
            Title = "My Popup";
            Message = "This is a popup message!";
        }

        [ObservableProperty]
        string message;
    }
}