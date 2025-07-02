namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _vm;
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            _vm = vm;
            BindingContext = _vm;
        }
    }
}