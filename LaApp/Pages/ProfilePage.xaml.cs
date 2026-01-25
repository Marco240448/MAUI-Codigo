using LaApp.ViewModels;

namespace LaApp.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage(ProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}