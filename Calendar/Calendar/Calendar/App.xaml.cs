﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calendar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.SchedulePage();
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
