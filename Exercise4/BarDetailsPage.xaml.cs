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
        }

        void CheckInPage(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Exercise4Page());

        }
    }
}
