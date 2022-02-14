using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Aplus.LocalDB;

namespace Aplus.PagesProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAbout : ContentPage
    {
        public string Description { get; set; }
        public PageAbout(Project project)
        {
            InitializeComponent();
            Description = project.Description;
            this.BindingContext = this;
        }
    }
}