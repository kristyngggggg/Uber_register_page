﻿using System;
using UberReg.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UberReg
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RegistrationPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
