﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Birthdate
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnGiftIdeasButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GiftIdeasPage());
        }

        async void OnCalendarButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CalendarView());
        }
    }
}
