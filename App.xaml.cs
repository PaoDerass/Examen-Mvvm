﻿using System;
using Microsoft.Maui.Controls;

namespace ExamenMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
