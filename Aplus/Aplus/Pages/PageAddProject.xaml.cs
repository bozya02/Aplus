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
	public partial class PageAddProject : ContentPage
	{
		public PageAddProject()
		{
			InitializeComponent();
		}

        private async void btnAddClicked(object sender, EventArgs e)
        {
            Project project = new Project()
            {
                Name = entryName.Text,
                Description = entryDesc.Text,
                Email = entryEmail.Text,
                Phone = entryPhone.Text,
                Address = entryAddress.Text
            };
            App.Database.AddProject(project);

            await Navigation.PushAsync(new PageProjects());
        }

        private async void btnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}