using LaApp.ViewModels;

namespace LaApp.Pages;

public partial class ConversorPage : ContentPage
{
   public ConversorPage(ConversorViewModel vm)
   {
        InitializeComponent();
        BindingContext = vm;
   }
}