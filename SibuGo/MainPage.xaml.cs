using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;

namespace SibuGo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Hook up the Pressed event for the buttons in Row 4
            btnAll.Pressed += OnButtonPressed;
            btnHotel.Pressed += OnButtonPressed;
            btnRestaurant.Pressed += OnButtonPressed;
            btnTrip.Pressed += OnButtonPressed;
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            // Implement your logic for the search button pressed event
        }

        private void OnButtonPressed(object sender, EventArgs e)
        {
            // Reset the appearance for all buttons
            ResetButtonAppearance();

            Button pressedButton = (Button)sender;
            pressedButton.BorderColor = Microsoft.Maui.Graphics.Color.FromRgb(37, 177, 255); // #25B1FF color
            pressedButton.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(37, 177, 255);
        }

        private void ResetButtonAppearance()
        {
            // Reset the appearance for all buttons
            btnAll.BorderColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128); // Gray color
            btnAll.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);

            btnHotel.BorderColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);
            btnHotel.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);

            btnRestaurant.BorderColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);
            btnRestaurant.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);

            btnTrip.BorderColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);
            btnTrip.TextColor = Microsoft.Maui.Graphics.Color.FromRgb(128, 128, 128);
        }

        private void OnButtonprofClick(object sender, EventArgs e)
        {
            // Implement your logic for the prof button click
        }

        private void OnButtonpackClick(object sender, EventArgs e)
        {
            // Implement your logic for the package button click
        }

        private void OnButtonrestClick(object sender, EventArgs e)
        {
            // Implement your logic for the restaurant button click
        }

        private void OnButtonhotlClick(object sender, EventArgs e)
        {
            // Implement your logic for the hotel button click
        }

        private void OnButtontripClick(object sender, EventArgs e)
        {
            // Implement your logic for the trip button click
        }
    }
}
