namespace MauiApp1;

public partial class MyPopup : ContentView
{
	MyPopupViewModel _vm;
	public MyPopup(MyPopupViewModel vm)
	{
		InitializeComponent();
		_vm = vm;
		BindingContext = _vm;
    }
}