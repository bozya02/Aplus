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
    public partial class PageImages : ContentPage
    {
        public PageImages(Project project)
        {
            InitializeComponent();
        }
    }
}