using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Aplus.LocalDB;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProjects : ContentPage
    {
        public List<Project> Projects { get; set; }
        public PageProjects()
        {
            InitializeComponent();
            Projects = new List<Project>();
            this.BindingContext = this;
        }

        private async void lwProjectsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new PageProject(lwProjects.SelectedItem as Project));
        }
    }
}