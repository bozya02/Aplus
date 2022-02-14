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
		public PageEditProject(Project project)
		{
			InitializeComponent();
		}
	}
}