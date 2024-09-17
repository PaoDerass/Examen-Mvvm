using System;
using Microsoft.Maui.Controls;

namespace ExamenMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           
            var mainPage = new MainPage();

           
            MainPage = new NavigationPage(mainPage)
            {
                BarBackgroundColor = Color.FromArgb("#F68BA2"), 
                BarTextColor = Colors.White       
            };
        }
    }
}
