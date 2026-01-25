using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Linq;
using System.Threading.Tasks;

namespace LaApp.ViewModels
{
    public partial class ConversorViewModel : ObservableObject
    {
        [ObservableProperty] private string _moneda1 = "0,00 €";
        [ObservableProperty] private string _moneda2 = "0,00 £";
        [ObservableProperty] private bool _tasa = true;
        [ObservableProperty] private string _cambio = "1.00 EUR = 0,867191 GBP";

        [RelayCommand]
        private async Task HomeBtn()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        [RelayCommand]
        private void CambiarMoneda()
        {
            Tasa = !Tasa;
            Moneda1 = Moneda2;

            if (Tasa)
            {
                Moneda2 = "0,00 £";
                Cambio = "1.00 EUR = 0,867191 GBP";
            }
            else
            {
                Moneda2 = "0,00 €";
                Cambio = "1.00 GBP = 1,152829 EUR";
            }
        }

        [RelayCommand]
        private void ConvertirMoneda()
        {
            // Cambiar
            char simboloOrigen = Tasa ? '€' : '£';
            char simboloDestino = Tasa ? '£' : '€';
            double factorConversion = Tasa ? 0.867734 : 1.152548;

            // Validar
            if (string.IsNullOrWhiteSpace(Moneda1))
            {
                Moneda1 = $"0,00 {simboloOrigen}";
                Moneda2 = $"0,00 {simboloDestino}";
                return;
            }

            // Limpiar
            if (Moneda1.EndsWith(simboloOrigen.ToString()))
            {
                Moneda1 = Moneda1.Remove(Moneda1.Length - 1).Trim();
            }

            // Calcular
            if (double.TryParse(Moneda1, out double valorNumerico))
            {
                double resultado = valorNumerico * factorConversion;

                // Mostrar
                Moneda1 = Moneda1.Contains(' ') ? $"{Moneda1}{simboloOrigen}" : $"{Moneda1} {simboloOrigen}";
                Moneda2 = $"{resultado:N2} {simboloDestino}";
            }
        }
    }
}