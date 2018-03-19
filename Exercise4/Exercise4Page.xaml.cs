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
        }


        void HomePage(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();


        }
    }
}
