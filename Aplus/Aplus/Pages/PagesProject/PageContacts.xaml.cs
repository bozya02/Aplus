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
    public partial class PageContacts : ContentPage
    {
        public PageContacts(Project project)
        {
            InitializeComponent();
            entryPhone.Text = project.Phone;
            entryEmail.Text = project.Email;
            entryAddress.Text = project.Address;
        }
    }
}