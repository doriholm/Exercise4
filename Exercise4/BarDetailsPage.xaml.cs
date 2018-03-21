using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Exercise4
{
    public partial class BarDetailsPage : ContentPage
    {
        public BarDetailsPage()
        {
            InitializeComponent();

            //Creating fake button by adding tap gesture on Label
            TapGestureRecognizer tapNavItem = new TapGestureRecognizer();
            tapNavItem.Tapped += NavItemTapped;

            NavItemBtn.GestureRecognizers.Add(tapNavItem);
        }

        void NavItemTapped(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Exercise4Page());

        }
    }
}
