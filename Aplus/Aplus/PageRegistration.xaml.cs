﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageRegistration : ContentPage
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private async void btnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}