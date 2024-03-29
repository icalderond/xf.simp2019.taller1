﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.simp2019.mvvm.Views;

//Views
//ViewModels
//Models

namespace xf.simp2019.mvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AccesoPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
