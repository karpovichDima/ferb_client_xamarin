﻿using System;
using App1.Data;
using App1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace App1
{
    public partial class App : Application
    {
        public static TokenDatabaseController tokenDatabase;
        public static UserDatabaseController userDatabase;

        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
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

        public static UserDatabaseController UserDatabase
        {
            get
            {
                if (userDatabase == null)
                {
                    userDatabase = new UserDatabaseController();
                }
                return userDatabase;
            }
        }

        public static TokenDatabaseController TokenDatabase
        {
            get
            {
                if (tokenDatabase == null)
                {
                    tokenDatabase = new TokenDatabaseController();
                }
                return tokenDatabase;
            }
        }
    }
}