using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exercise4
{
    public partial class Exercise4Page : ContentPage
    {
        public Exercise4Page()
        {
            InitializeComponent();

            //Creating fake buttons by adding tap gesture on Labels
            TapGestureRecognizer tapCheckIn = new TapGestureRecognizer();
            tapCheckIn.Tapped += CheckInTapped;

                checkInBtn.GestureRecognizers.Add(tapCheckIn);

            TapGestureRecognizer tapNavItem = new TapGestureRecognizer();
            tapNavItem.Tapped += NavItemTapped;

                NavItemBtn.GestureRecognizers.Add(tapNavItem);
        }

        private void CheckInTapped(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Confirm", "Check in to Joe's Bar", "Yes", "No");
        }

        private void NavItemTapped(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();


        }
    }
}
