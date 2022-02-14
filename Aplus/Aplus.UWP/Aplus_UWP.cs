using System;
using System.IO;
using Windows.Storage;
using Aplus.LocalDB;
using Xamarin.Forms;
using Aplus.UWP;

[assembly: Dependency(typeof(Aplus_UWP))]
namespace Aplus.UWP
{
    public class Aplus_UWP : ISQLite
    {
        public Aplus_UWP() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            // для доступа к файлам используем API Windows.Storage
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            return path;
        }
    }
}
