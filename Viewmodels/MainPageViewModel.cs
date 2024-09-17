using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace ExamenMvvm
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private decimal pro1;

        [ObservableProperty]
        private decimal pro2;

        [ObservableProperty]
        private decimal pro3;

        [ObservableProperty]
        private decimal subtotal;

        [ObservableProperty]
        private decimal descuento;

        [ObservableProperty]
        private decimal totalPagar;

        public MainPageViewModel()
        {
            Pro1 = 0;
            Pro2 = 0;
            Pro3 = 0;
        }

        [RelayCommand]
        public void Calcular()
        {
            try
            {
                if (Pro1 < 0 || Pro2 < 0 || Pro3 < 0)
                {
                    throw new ArgumentException("Los valores de los productos no pueden ser negativos.");
                }

                Subtotal = Pro1 + Pro2 + Pro3;

                if (Subtotal >= 10000)
                {
                    Descuento = Subtotal * 0.30m;
                }
                else if (Subtotal >= 5000)
                {
                    Descuento = Subtotal * 0.20m;
                }
                else if (Subtotal >= 1000)
                {
                    Descuento = Subtotal * 0.10m;
                }
                else
                {
                    Descuento = 0;
                }

                TotalPagar = Subtotal - Descuento;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al calcular: {ex.Message}");
            }
        }

        [RelayCommand]
        public void Limpiar()
        {
            Pro1 = 0;
            Pro2 = 0;
            Pro3 = 0;
            Subtotal = 0;
            Descuento = 0;
            TotalPagar = 0;
        }
    }
}
