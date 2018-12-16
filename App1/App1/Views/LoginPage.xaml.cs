using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            LblUsername.TextColor = Constants.MainTextColor;
            LblPassword.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LogicIconHeight;

            EntryUsername.Completed += (s, e) => EntryPassword.Focus();
            EntryPassword.Completed += SignInProcedure;
        }

        private void SignInProcedure(object sender, EventArgs e)
        {
            var user = new User(EntryUsername.Text, EntryPassword.Text);
            DisplayAlert("Login",
                user.CheckInformation() ? "Login Success." : "Login not correct, empty username or password", "Ok");
        }
    }
}