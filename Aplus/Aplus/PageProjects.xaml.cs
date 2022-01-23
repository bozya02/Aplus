using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProjects : ContentPage
    {
        public List<Project> Projects { get; set; }
        public PageProjects()
        {
            InitializeComponent();
            FillList();
            this.BindingContext = this;
        }

        public void FillList()
        {
            for (int i = 0; i < 20; i++)
            {
                Projects.Add(new Project($"Проект {i + 1}"));
            }
        }

        private async void lwProjectsItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new PageProject((lwProjects.SelectedItem as Project).Name));
        }
    }
}