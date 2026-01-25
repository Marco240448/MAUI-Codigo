using LaApp.ViewModels;

namespace LaApp.Pages;

public partial class CochePage : ContentPage
{
	public CochePage(CocheViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}