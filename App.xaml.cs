﻿using Ble.Client;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Bluetooth_Terminal_PluginBluetoothLE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            var navigationPage = new NavigationPage(new BtDevPage());
            MainPage = navigationPage;
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
