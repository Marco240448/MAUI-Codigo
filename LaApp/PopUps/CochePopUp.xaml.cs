using CommunityToolkit.Maui.Views;
using LaApp.Models;
using LaApp.ViewModels;

namespace LaApp.PopUps;

public partial class CochePopUp : Popup<Coches>
{
	public CochePopUp(CochePopUpViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}