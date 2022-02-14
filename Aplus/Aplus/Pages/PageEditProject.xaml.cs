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
	public partial class PageEditProject : ContentPage
	{
        public Project project { get; set; }
		public PageEditProject(Project newProject)
		{
			InitializeComponent();
            project = newProject;
		}

        private async void tbDeleteClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите удалить {project.Name}", "Удалить", "Отмена");

            if (result)
            {
                App.Database.DeleteProject(project.Id);
                await Navigation.PushAsync(new PageProjects());
            }
        }

        private async void btnEditClicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("", $"Вы точно хотите изменить {project.Name}", "Изменить", "Отмена");
            
            Project newProject = new Project
            {
                Id = project.Id,
                Name = entryName.Text,
                Description = entryDesc.Text,
                Phone = entryPhone.Text,
                Email = entryEmail.Text,
                Address = entryAddress.Text
            };
            
            if (result)
            {
                App.Database.AddProject(project);
                await Navigation.PushAsync(new PageProjects());
            }
            
        }

        private async void btnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}