using Microsoft.Maui.Controls;

namespace SibuGo
{
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Add your login logic here
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            // Perform authentication or other actions as needed

            // For demo purposes, show an alert
            DisplayAlert("Login", $"Username: {username}\nPassword: {password}", "OK");
        }

        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // Add your sign-up navigation logic here
            // For demo purposes, navigate to a sign-up page
            Navigation.PushAsync(new ());
        }

        private void OnForgotPasswordTapped(object sender, EventArgs e)
        {
            // Add your logic for handling forgot password
            DisplayAlert("Forgot Password", "Reset password logic goes here", "OK");
        }
    }
}
