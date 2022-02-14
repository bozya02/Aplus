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
    public partial class PageProject : TabbedPage
    {
        public Project project { get; set; }
        public PageProject(Project newProject)
        {
            InitializeComponent();
            project = newProject;

            Title = project.Name;

            Children.Add(new PagesProject.PageAbout(project));
            Children.Add(new PagesProject.PageImages(project));
            Children.Add(new PagesProject.PageContacts(project));
        }

        private async void tbEditClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageEditProject(project));
        }
    }
}