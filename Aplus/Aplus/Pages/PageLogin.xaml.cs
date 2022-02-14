using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplus
{
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private async void btnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageRegistration());
        }

        private async void btnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageProjects());
        }
    }
}
